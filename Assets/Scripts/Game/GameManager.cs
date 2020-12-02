using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public VoidEvent RestartGameEvent;

    private void Start() {
        RestartGameEvent.Register(RestartGame);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            RestartGame();
        }
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnDestroy() {
        RestartGameEvent.Unregister(RestartGame);
    }
}
