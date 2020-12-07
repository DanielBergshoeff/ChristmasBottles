using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string LandSound;

    [FMODUnity.EventRef]
    public string PushedSound;

    public FloatVariable MoveSpeed;
    public FloatVariable MaxSpeed;

    private Rigidbody myRigidbody;
    private List<Ripple> myRipples;
    private List<Current> myCurrents;

    private void Awake() {
        myRigidbody = GetComponent<Rigidbody>();
        myRipples = new List<Ripple>();
        myCurrents = new List<Current>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBottle();
    }

    private void MoveBottle() {
        foreach (Ripple r in myRipples) {
            Vector3 direction = transform.position - r.transform.position;
            Vector3 heading = direction.normalized;
            myRigidbody.AddForce(heading * MoveSpeed.Value);
        }

        foreach (Current c in myCurrents) {
            myRigidbody.AddForce(c.transform.forward * c.Speed);
        }

        var v = myRigidbody.velocity;
        if (v.sqrMagnitude > MaxSpeed.Value * MaxSpeed.Value) {
            myRigidbody.velocity = v.normalized * MaxSpeed.Value;
        }
    }


    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.CompareTag("Land")) {
            AudioManager.PlayOnMe(LandSound, transform);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ripple")) {
            Ripple r = other.GetComponent<Ripple>();
            if (!myRipples.Contains(r)) {
                myRipples.Add(r);
            }

            AudioManager.PlayOnMe(PushedSound, transform);
        }
        else if (other.CompareTag("Current")) {
            Current c = other.GetComponent<Current>();
            if (!myCurrents.Contains(c)) {
                myCurrents.Add(c);
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Ripple")) {
            Ripple r = other.GetComponent<Ripple>();
            if (myRipples.Contains(r)) {
                myRipples.Remove(r);
            }
        }
        else if (other.CompareTag("Current")) {
            Current c = other.GetComponent<Current>();
            if (myCurrents.Contains(c)) {
                myCurrents.Remove(c);
            }
        }
    }

    public void RippleRemoved(Ripple r) {
        if (myRipples == null)
            return;

        if (myRipples.Contains(r)){
            myRipples.Remove(r);
        }
    }

    public void CurrentRemoved(Current c) {
        if (myCurrents == null)
            return;

        if (myCurrents.Contains(c)) {
            myCurrents.Remove(c);
        }
    }
}
