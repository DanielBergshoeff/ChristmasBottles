using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string InterfaceSound;

    public void QuitGame()
    {
        PlayInterfaceSound();
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

    public void PlayGame()  
    {
        PlayInterfaceSound();
        SceneManager.LoadScene(1);
    }

    public void PlayInterfaceSound() {
        RuntimeManager.PlayOneShot(InterfaceSound);
    }
}
