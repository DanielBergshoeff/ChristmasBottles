using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UnityEngine.UI;

public class LetterSystem : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string LetterOpen;

    [FMODUnity.EventRef]
    public string LetterClose;

    public GameObject LetterPartPrefab;

    public VoidEvent NextLevelEvent;

    public GameObject Letter;
    public GameObject NextButton;
    public GameObject PreviousButton;
    public GameObject CloseLetterButton;

    private SpriteLetter currentLetter;
    private List<GameObject> spriteObjects;
    private int currentPart = 0;

    private Queue<SpriteLetter> myLetters;

    private void Awake() {
        myLetters = new Queue<SpriteLetter>();
    }

    private void Update() {
        if (currentLetter == null)
            return;

        if (Input.GetMouseButtonDown(0)) {
            if (currentPart < spriteObjects.Count - 1)
                NextPart();
        }
    }

    public void ShowLetter(SpriteLetter l) {
        if (currentLetter != null) {
            myLetters.Enqueue(l);
            return;
        }

        Letter.SetActive(true);
        currentPart = -1;
        currentLetter = l;
        if(currentLetter.Parts.Count > 0) {
            NextButton.SetActive(true);
        }

        spriteObjects = new List<GameObject>();
        for (int i = 0; i < l.Parts.Count; i++) {
            GameObject go = Instantiate(LetterPartPrefab, Letter.transform, false);
            go.GetComponent<Image>().sprite = l.Parts[i];
            spriteObjects.Add(go);
            go.SetActive(false);
        }

        AudioManager.PlayOnMe(LetterOpen, transform);

        NextPart();
    }

    public void NextPart() {
        currentPart++;
        spriteObjects[currentPart].SetActive(true);

        UpdateButtons();
    }

    private void UpdateButtons() {
        /*if (currentPart == 0) {
            PreviousButton.SetActive(false);
        }
        else {
            PreviousButton.SetActive(true);
        }*/

        if (currentPart == currentLetter.Parts.Count - 1) {
            NextButton.SetActive(false);
            CloseLetterButton.SetActive(true);
        }
        else {
            NextButton.SetActive(true);
            CloseLetterButton.SetActive(false);
        }
    }

    public void PreviousPart() {
        if (currentPart - 1 < 0)
            return;

        spriteObjects[currentPart].SetActive(false);
        currentPart--;


        UpdateButtons();
    }

    public void CloseLetter() {
        currentLetter = null;
        foreach(GameObject go in spriteObjects) {
            Destroy(go);
        }
        Letter.SetActive(false);

        AudioManager.PlayOnMe(LetterClose, transform);

        if(!CheckForNewLetter())
            NextLevelEvent.Raise();
    }

    public bool CheckForNewLetter() {
        if (myLetters.Count == 0)
            return false;

        ShowLetter(myLetters.Dequeue());

        return true;
    }
}

[System.Serializable]
public class Letter
{
    public List<string> Parts;
}

[System.Serializable]
public class SpriteLetter
{
    public List<Sprite> Parts;
}
