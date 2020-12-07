using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string InterfaceSound;

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
        PlayInterfaceSound();
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

    public void Pause() {
        PlayInterfaceSound();
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
        paused = true;
    }

    public void UnPause() {
        PlayInterfaceSound();
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
        paused = false;
    }

    public void PlayInterfaceSound() {
        RuntimeManager.PlayOneShot(InterfaceSound);
    }
}
