using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;
using FMODUnity;

public class AudioManager : MonoBehaviour
{
    public static void PlayOnMe(string clip, Transform target) {
        if (clip == default)
            return;

        try {
            EventInstance soundToPlay = RuntimeManager.CreateInstance(clip);
            soundToPlay.set3DAttributes(RuntimeUtils.To3DAttributes(target));
            soundToPlay.start();
        }
        catch (System.Exception) {
            
        }
    }
}
