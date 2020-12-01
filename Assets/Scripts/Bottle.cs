using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    public FloatVariable MoveSpeed;
    public FloatVariable MaxSpeed;

    private Rigidbody myRigidbody;
    private List<Ripple> myRipples;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRipples = new List<Ripple>();
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

        /*foreach (GameObject go in streams) {
            myRigidbody.AddForce(-go.transform.up * 0.3f);
        }*/

        var v = myRigidbody.velocity;
        if (v.sqrMagnitude > MaxSpeed.Value * MaxSpeed.Value) {
            myRigidbody.velocity = v.normalized * MaxSpeed.Value;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (!other.CompareTag("Ripple"))
            return;

        Ripple r = other.GetComponent<Ripple>();
        if (!myRipples.Contains(r)) {
            myRipples.Add(r);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (!other.CompareTag("Ripple"))
            return;

        Ripple r = other.GetComponent<Ripple>();
        if (myRipples.Contains(r)) {
            myRipples.Remove(r);
        }
    }

    public void RippleRemoved(Ripple r) {
        if (myRipples.Contains(r)){
            myRipples.Remove(r);
        }
    }
}
