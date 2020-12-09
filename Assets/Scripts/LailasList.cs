using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using FMODUnity;
using UnityEngine.SceneManagement;

public class LailasList : MonoBehaviour
{
    public GameObject MyList;
    public FloatEvent FadeOutEvent;

    [FMODUnity.EventRef]
    public string LetterCloseSound;

    [FMODUnity.EventRef]
    public string BottleCloseSound;

    public float FadeOutTime = 3f;

    public void StartInput() {
        MyList.SetActive(true);
    }

    public void SendMessage() {
        MyList.SetActive(false);
        FadeOutEvent.Raise(FadeOutTime);
        RuntimeManager.PlayOneShot(LetterCloseSound);
        Invoke("StartEndGame", FadeOutTime);
    }

    private void StartEndGame() {
        RuntimeManager.PlayOneShot(BottleCloseSound);
        Invoke("EndGame", 3f);
    }

    private void EndGame() {
        SceneManager.LoadScene(0);
    }
}
