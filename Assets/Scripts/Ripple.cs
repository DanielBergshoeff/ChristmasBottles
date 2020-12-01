using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ripple : MonoBehaviour
{
    public static RippleEvent DestroyEvent;
    public float totalSize = 1f;
    public float timeTillFull = 1f;

    private float startTime = 0f;
    private bool growing = false;

    void Start() {
        DestroyEvent = new RippleEvent();
        startTime = Time.time;
        growing = true;
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
}

public class RippleEvent : UnityEvent<Ripple> { }
