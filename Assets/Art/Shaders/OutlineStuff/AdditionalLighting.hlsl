void AdditionalLights_float(float3 WorldPosition, float3 WorldNormal, out float3 Diffuse, out float3 Color, out float DistanceAtten, out float ShadowAtten)
{
    float3 diffuseColor = 0;
	Color = 1;
    DistanceAtten = 1;
    ShadowAtten = 1;

#ifndef SHADERGRAPH_PREVIEW
    WorldNormal = normalize(WorldNormal);
    int pixelLightCount = GetAdditionalLightsCount();

    for (int i = 0; i < pixelLightCount; ++i)
    {
        Light light = GetAdditionalLight(i, WorldPosition);
        half3 attenuatedLightColor = light.distanceAttenuation * light.shadowAttenuation;
        diffuseColor += LightingLambert(attenuatedLightColor, light.direction, WorldNormal);
       
	   
	   DistanceAtten = light.distanceAttenuation;
	   Color = light.color; 
	   ShadowSamplingData shadowSamplingData = GetAdditionalLightShadowSamplingData();
	   half shadowStrength = GetAdditionalLightShadowStrenth(i);

	   float4 shadowCoord = mul(_AdditionalLightsWorldToShadow[i], WorldPosition);
	   half4 shadowParams = GetAdditionalLightShadowParams(i);
	   ShadowAtten = SampleShadowmap(TEXTURE2D_ARGS(_AdditionalLightsShadowmapTexture, sampler_AdditionalLightsShadowmapTexture), shadowCoord, shadowSamplingData, shadowStrength, false);
    }
#endif

    Diffuse = diffuseColor;

}
