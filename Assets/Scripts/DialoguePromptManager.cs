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
    private float cooldownTimer = 0f;

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

        if (cooldownTimer > 0f) {
            cooldownTimer -= Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0) && cooldownTimer <= 0f && dialogueTimer < 1f) {
            cooldownTimer = 0.1f;
            dialogueTimer = 1f;
        }

        dialogueTimer += (Time.deltaTime / currentDialogue.Length) * TextSpeed;
        int l = (int)Mathf.Clamp(currentDialogue.Length * dialogueTimer, 1f, currentDialogue.Length);
        dialogueText.text = currentDialogue.Substring(0, l);
        if(currentDialogue.Length * dialogueTimer >= currentDialogue.Length + StayTime * TextSpeed) {
            EndDialogue();
        }
    }

    public void StartDialogue(string d) {
        dialogueTimer = 0f;
        currentDialogue = d;
    }

    public void EndDialogue() {
        currentDialogue = "";
        dialogueText.text = "";
    }
}
