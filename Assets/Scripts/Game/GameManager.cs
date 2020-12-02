using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public VoidEvent RestartGameEvent;
    public VoidEvent NextLevelEvent;
    public Image FadePanel;
    public float FadeTime = 3f;

    private Color fadeColor;
    private float currentFade;

    private float startFadeTime = 0f;
    private bool fadeIn = false;
    private bool fadeOut = false;

    private void Awake() {
        fadeColor = FadePanel.color;
    }

    private void Start() {
        RestartGameEvent.Register(StartRestartGame);
        NextLevelEvent.Register(StartNextLevel);

        FadeIn();
    }

    private void Update() {
        if (fadeIn || fadeOut) {
            float t = 0f;
            if (fadeIn)
                t = 1f - (Time.time - startFadeTime) / FadeTime;
            else
                t = (Time.time - startFadeTime) / FadeTime;

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

    private void FadeIn() {
        Debug.Log("Fading in");
        fadeIn = true;
        startFadeTime = Time.time;
        FadePanel.enabled = true;
    }

    private void FadeOut() {
        Debug.Log("Fading out");
        fadeOut = true;
        startFadeTime = Time.time;
        FadePanel.enabled = true;
    }

    public void StartRestartGame() {
        FadeOut();
        Invoke("RestartGame", FadeTime);
    }

    private void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartNextLevel() {
        FadeOut();
        Invoke("NextLevel", FadeTime);
    }

    private void NextLevel() {
        if (SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            SceneManager.LoadScene(0);
    }

    private void OnDestroy() {
        RestartGameEvent.Unregister(StartRestartGame);
        NextLevelEvent.Unregister(StartNextLevel);
    }
}
