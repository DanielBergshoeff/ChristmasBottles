using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public StringEvent TutorialShowEvent;
    public float WaitForButtonPress = 5f;
    public string TutorialText;
    public KeyCode KeyPressCheck;

    private bool pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("CheckForTutorial", WaitForButtonPress);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyPressCheck)) {
            pressed = true;
        }
    }

    private void CheckForTutorial() {
        if (!pressed) {
            TutorialShowEvent.Raise(TutorialText);
        }
    }
}
