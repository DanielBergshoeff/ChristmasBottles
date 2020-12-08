void CalculateMainLight_float(float3 WorldPos, out half3 Direction, out half3 Color, out half DistanceAtten, out half ShadowAtten)
{
    #if SHADERGRAPH_PREVIEW
        Direction = half3(0.5, 0.5, 0);
        Color = 1;
        DistanceAtten = 1;
        ShadowAtten = 1;
    #else

            half cascadeIndex = ComputeCascadeIndex(WorldPos);
			half4 shadowCoord = mul(_MainLightWorldToShadow[cascadeIndex], float4(WorldPos, 1.0));

            Light mainLight = GetMainLight(shadowCoord);
            Direction = mainLight.direction;
            Color = mainLight.color;
            DistanceAtten = mainLight.distanceAttenuation;
 
        #if !defined(_MAIN_LIGHT_SHADOWS) || defined(_RECEIVE_SHADOWS_OFF)
            ShadowAtten = 1.0h;
        #endif

            ShadowSamplingData shadowSamplingData = GetMainLightShadowSamplingData();
            half shadowStrength = GetMainLightShadowStrength();
            ShadowAtten = SampleShadowmap(shadowCoord, TEXTURE2D_ARGS(_MainLightShadowmapTexture,
            sampler_MainLightShadowmapTexture),
            shadowSamplingData, shadowStrength, false);

    #endif
} 

void CalculateAdditionalLights_float(float Smoothness, float3 WorldPos, float3 WorldNormal, float3 WorldView, float MainDiffuse, float MainSpecular, float3 MainColor, out half Specular, out half Diffuse, out float3 Color)
{

	Diffuse = MainDiffuse;
	Specular = MainSpecular;
	Color = MainColor * (MainDiffuse + MainSpecular);

    #ifndef SHADERGRAPH_PREVIEW
        int pixelLightCount = GetAdditionalLightsCount();
		for(int i = 0; i < pixelLightCount; i++)
		{
		Light light = GetAdditionalLight(i, WorldPos);
		half NdotL = saturate(dot(WorldNormal, light.direction));
		half atten = light.distanceAttenuation * light.shadowAttenuation;
		half thisDiffuse = atten * NdotL;
		half thisSpecular = LightingSpecular(thisDiffuse, light.direction, WorldNormal, WorldView, 1, Smoothness);

		Diffuse += thisDiffuse;
		Specular += thisSpecular; 
		Color += light.color *  (thisDiffuse + thisSpecular);

		}
#endif

	half total = Diffuse + Specular;
    Color = total <= 0 ? MainColor : Color / total;
}

