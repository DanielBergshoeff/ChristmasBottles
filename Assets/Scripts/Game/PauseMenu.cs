using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;

    private bool paused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!paused)
                Pause();
            else
                UnPause();
        }
    }

    public void Quit() {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }

    public void Pause() {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
        paused = true;
    }

    public void UnPause() {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
        paused = false;
    }
}
