using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public FloatReference TextSpeed;
    public FloatReference StayTime;

    public StringEvent SwitchMusic;
    [FMODUnity.EventRef]
    public string IntroMusic;

    [FMODUnity.EventRef]
    public string PostIntroMusic;

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
            Invoke("NextIntroPart", TimePerPart + IntroductionText.Parts[currentIntroPart].Length / TextSpeed.Value + StayTime.Value);
        }
        else {
            EndIntro();
        }
    }

    private void EndIntro() {
        FadeInEvent.Raise(FadeInTime);
        SwitchMusic.Raise(PostIntroMusic);
    }
}
