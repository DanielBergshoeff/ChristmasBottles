using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class DialoguePromptManager : MonoBehaviour
{
    public FloatReference TextSpeed;
    public FloatReference StayTime;

    private string currentDialogue;
    private float dialogueTimer = 0f;
    private TMPro.TextMeshProUGUI dialogueText;

    // Start is called before the first frame update
    void Start()
    {
        dialogueText = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        dialogueText.text = "";
        currentDialogue = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDialogue == "")
            return;

        dialogueTimer += (Time.deltaTime / currentDialogue.Length) * TextSpeed;
        int l = (int)Mathf.Clamp(currentDialogue.Length * dialogueTimer, 1f, currentDialogue.Length);
        dialogueText.text = currentDialogue.Substring(0, l);
        if(currentDialogue.Length * dialogueTimer >= currentDialogue.Length + StayTime * TextSpeed) {
            currentDialogue = "";
            dialogueText.text = "";
        }
    }

    public void StartDialogue(string d) {
        dialogueTimer = 0f;
        currentDialogue = d;
    }
}
