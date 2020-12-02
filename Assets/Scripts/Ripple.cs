using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

public class Ripple : MonoBehaviour
{
    public static RippleEvent DestroyEvent;
    public RippleValueList AllRipples;
    public float totalSize = 1f;
    public float timeTillFull = 1f;

    private float startTime = 0f;
    private bool growing = false;

    private void Awake() {
        DestroyEvent = new RippleEvent();
        startTime = Time.time;
        growing = true;
        AllRipples.Add(this);
    }

    private void Update() {
        if (!growing)
            return;

        float t = Time.time - startTime;
        if (t > timeTillFull) {
            transform.localScale = new Vector3(totalSize, totalSize, totalSize);
            growing = false;
            DestroyEvent.Invoke(this);
            Destroy(gameObject);
        }
        else {
            t = t / timeTillFull;
            transform.localScale = new Vector3(t * totalSize, t * totalSize, t * totalSize);
        }
    }

    private void OnDisable() {
        AllRipples.Remove(this);
    }
}

public class RippleEvent : UnityEvent<Ripple> { }
