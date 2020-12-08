using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public FloatEvent FadeInEvent;
    public FloatEvent FadeOutEvent;

    public VoidEvent RestartGameEvent;
    public VoidEvent NextLevelEvent;
    public float FadeOutTime = 3f;
    

    private void Start() {
        RestartGameEvent.Register(StartRestartGame);
        NextLevelEvent.Register(StartNextLevel);
    }

    public void StartRestartGame() {
        FadeOutEvent.Raise(FadeOutTime);
        Invoke("RestartGame", FadeOutTime);
    }

    private void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartNextLevel() {
        FadeOutEvent.Raise(FadeOutTime);
        Invoke("NextLevel", FadeOutTime);
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
