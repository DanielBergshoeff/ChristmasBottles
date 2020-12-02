using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public VoidEvent RestartGameEvent;
    public StringVariable BreakTag;
    public int Phases = 3;
    public FloatVariable VelocityForCrack;

    public IntVariable CurrentPhase;

    private bool broken = false;
    private Rigidbody myRigidbody;

    private void Start() {
        CurrentPhase.Value = 0;
        myRigidbody = GetComponent<Rigidbody>();
    }

    private void Update() {
        if (!broken)
            return;

        transform.position = transform.position - Vector3.up * 0.1f * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision) {
        if (broken || !collision.collider.CompareTag(BreakTag.Value))
            return;

        if(myRigidbody.velocity.sqrMagnitude > VelocityForCrack.Value * VelocityForCrack.Value) {
            OnCrack();
        }
    }

    private void OnCrack() {
        if (broken)
            return;

        CurrentPhase.Value++;
        if(CurrentPhase.Value >= Phases) {
            broken = true;
            Invoke("Break", 3f);
        }
    }

    private void Break() {
        RestartGameEvent.Raise();
    }
}
