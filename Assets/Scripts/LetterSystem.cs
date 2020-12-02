﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityAtoms;

public class LetterSystem : MonoBehaviour
{
    public VoidEvent NextLevelEvent;

    public GameObject Letter;
    public TextMeshProUGUI LetterText;
    public GameObject NextButton;
    public GameObject PreviousButton;
    public GameObject CloseLetterButton;

    private Letter currentLetter;
    private int currentPart = 0;

    public void ShowLetter(Letter l) {
        Letter.SetActive(true);
        currentPart = -1;
        currentLetter = l;
        if(currentLetter.Parts.Count > 0) {
            NextButton.SetActive(true);
        }

        NextPart();
    }

    public void NextPart() {
        currentPart++;
        LetterText.text = currentLetter.Parts[currentPart];

        if(currentPart == currentLetter.Parts.Count - 1) {
            NextButton.SetActive(false);
            CloseLetterButton.SetActive(true);
        }
        else {
            NextButton.SetActive(true);
            if (currentPart > 0)
                PreviousButton.SetActive(true);
        }
    }

    public void PreviousPart() {
        if (currentPart - 1 < 0)
            return;

        currentPart--;
        LetterText.text = currentLetter.Parts[currentPart];

        if(currentPart == 0) {
            PreviousButton.SetActive(false);
        }
    }

    public void CloseLetter() {
        Debug.Log("Close");
        currentLetter = null;
        Letter.SetActive(false);
        NextLevelEvent.Raise();
    }
}

[System.Serializable]
public class Letter
{
    public List<string> Parts;
}