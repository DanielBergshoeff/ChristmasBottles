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
    private Transform colliderTransform;
    private MeshRenderer myMeshRenderer;

    private void Awake() {
        DestroyEvent = new RippleEvent();
        startTime = Time.time;
        growing = true;
        AllRipples.Add(this);
        colliderTransform = GetComponentInChildren<Collider>().transform;
        myMeshRenderer = GetComponentInChildren<MeshRenderer>();
        myMeshRenderer.material = Instantiate(myMeshRenderer.material);
        myMeshRenderer.material.SetFloat("_RipplePos", 0f);
    }

    private void Update() {
        if (!growing)
            return;

        float t = Time.time - startTime;
        if (t > timeTillFull) {
            colliderTransform.localScale = new Vector3(totalSize, totalSize, totalSize);
            growing = false;
            DestroyEvent.Invoke(this);
            Destroy(gameObject);
        }
        else {
            t = t / timeTillFull;
            colliderTransform.localScale = new Vector3(t * totalSize, t * totalSize, t * totalSize);
            myMeshRenderer.material.SetFloat("_RipplePos", t * 2f);
        }
    }

    private void OnDisable() {
        AllRipples.Remove(this);
    }
}

public class RippleEvent : UnityEvent<Ripple> { }
