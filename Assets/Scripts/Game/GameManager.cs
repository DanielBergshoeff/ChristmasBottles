using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public VoidEvent RestartGameEvent;
    public VoidEvent NextLevelEvent;

    private void Start() {
        RestartGameEvent.Register(RestartGame);
        NextLevelEvent.Register(NextLevel);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel() {
        if (SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            SceneManager.LoadScene(0);
    }

    private void OnDestroy() {
        RestartGameEvent.Unregister(RestartGame);
        NextLevelEvent.Unregister(NextLevel);
    }
}
