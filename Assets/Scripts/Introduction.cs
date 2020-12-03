using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public StringEvent SwitchMusic;
    [FMODUnity.EventRef]
    public string IntroMusic;
    public FloatEvent FadeInEvent;
    public StringEvent DialogueEvent;
    public VoidEvent InstantFadeEvent;

    public Letter IntroductionText;
    public float TimePerPart = 5f;
    public float FadeInTime = 3f;
    public float StartWaitTime = 3f;

    private int currentIntroPart = 0;

    // Start is called before the first frame update
    void Start()
    {
        InstantFadeEvent.Raise();
        Invoke("StartIntro", StartWaitTime);
        SwitchMusic.Raise(IntroMusic);
    }

    private void StartIntro() {
        if (IntroductionText != null) {
            currentIntroPart = -1;
            NextIntroPart();
        }
        else {
            EndIntro();
        }
    }

    private void NextIntroPart() {
        currentIntroPart++;
        if (currentIntroPart < IntroductionText.Parts.Count) {
            DialogueEvent.Raise(IntroductionText.Parts[currentIntroPart]);
            Invoke("NextIntroPart", TimePerPart);
        }
        else {
            EndIntro();
        }
    }

    private void EndIntro() {
        FadeInEvent.Raise(FadeInTime);
    }
}
