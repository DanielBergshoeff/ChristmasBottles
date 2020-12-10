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
    private float timer = 0f;
    private int timesPressed = 0;

    // Start is called before the first frame update
    void Start()
    {
        InstantFadeEvent.Raise();
        SwitchMusic.Raise(IntroMusic);
        currentIntroPart = -1;
        timer = StartWaitTime;
        if(StartWaitTime == 0f) {
            NextIntroPart();
        }
    }

    private void Update() {
        if(timer > 0f) {
            if (Input.GetMouseButtonDown(0)) {
                timesPressed++;
                if(timesPressed > 1) {
                    timer = -1f;
                }
            }
            timer -= Time.deltaTime;
            if(timer <= 0f) {
                NextIntroPart();
            }
        }
    }

    private void NextIntroPart() {
        currentIntroPart++;
        if (currentIntroPart < IntroductionText.Parts.Count) {
            DialogueEvent.Raise(IntroductionText.Parts[currentIntroPart]);
            timer = TimePerPart + IntroductionText.Parts[currentIntroPart].Length / TextSpeed.Value + StayTime.Value;
            timesPressed = 0;
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
