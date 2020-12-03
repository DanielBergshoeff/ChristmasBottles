using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;
using FMODUnity;

public class MusicManager : MonoBehaviour
{
    private EventInstance currentMusic;

    public void ClipToPlay(string clip) {
        if (clip != default) {
            currentMusic = RuntimeManager.CreateInstance(clip);
            currentMusic.set3DAttributes(RuntimeUtils.To3DAttributes(transform));
            currentMusic.start();
        }
        else
            currentMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    private void OnDestroy() {
        currentMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }
}
