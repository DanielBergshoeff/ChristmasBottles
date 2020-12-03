using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeSystem : MonoBehaviour
{
    public Image FadePanel;

    private Color fadeColor;

    private float startFadeTime = 0f;
    private bool fadeIn = false;
    private bool fadeOut = false;

    private float totalFadeTime;

    private void Awake() {
        fadeColor = FadePanel.color;
    }

    private void Update() {
        if (fadeIn || fadeOut) {
            float t = 0f;
            if (fadeIn)
                t = 1f - (Time.time - startFadeTime) / totalFadeTime;
            else
                t = (Time.time - startFadeTime) / totalFadeTime;

            if (t > 1f || t < 0f) {
                if (t < 0f)
                    FadePanel.enabled = false;
                fadeIn = false;
                fadeOut = false;
            }
            else {
                fadeColor.a = t;
                FadePanel.color = fadeColor;
            }
        }
    }

    public void InstantFadeOut() {
        FadePanel.enabled = true;
        fadeColor.a = 1f;
        FadePanel.color = fadeColor;
    }

    public void FadeIn(float time) {
        totalFadeTime = time;
        fadeIn = true;
        startFadeTime = Time.time;
        FadePanel.enabled = true;
    }

    public void FadeOut(float time) {
        totalFadeTime = time;
        fadeOut = true;
        startFadeTime = Time.time;
        FadePanel.enabled = true;
    }
}
