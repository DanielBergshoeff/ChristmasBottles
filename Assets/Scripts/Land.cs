using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

public class Land : MonoBehaviour
{
    public SpriteLetterEvent DisplayLetterEvent;
    public SpriteLetterVariable MyLetter;
    public SpriteLetterVariable WishList;

    private bool triggered = false;

    private void OnCollisionEnter(Collision collision) {
        if (!collision.collider.CompareTag("Player") || triggered)
            return;

        DisplayLetterEvent.Raise(MyLetter.Value);
        if(WishList != null)
            DisplayLetterEvent.Raise(WishList.Value);
        triggered = true;
    }
}
