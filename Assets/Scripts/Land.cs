﻿using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

public class Land : MonoBehaviour
{
    public LetterEvent DisplayLetterEvent;
    public LetterVariable MyLetter;

    private bool triggered = false;

    private void OnCollisionEnter(Collision collision) {
        if (!collision.collider.CompareTag("Player") || triggered)
            return;

        DisplayLetterEvent.Raise(MyLetter.Value);
        triggered = true;
    }
}
