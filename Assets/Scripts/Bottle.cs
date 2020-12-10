using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class Bottle : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string LandSound;

    [FMODUnity.EventRef]
    public string WaterCurrentSound;

    public FloatVariable MoveSpeed;
    public FloatVariable MaxSpeed;

    public Transform BottleModel;
    public FloatVariable MaxRotation;

    private Rigidbody myRigidbody;
    private List<Ripple> myRipples;
    private List<Current> myCurrents;

    private EventInstance waterCurrentSound;

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
            if(myRigidbody.velocity.sqrMagnitude < c.MaxSpeed * c.MaxSpeed)
                myRigidbody.AddForce(c.transform.forward * c.Speed);
        }

        var v = myRigidbody.velocity;
        if (v.sqrMagnitude > MaxSpeed.Value * MaxSpeed.Value) {
            myRigidbody.velocity = v.normalized * MaxSpeed.Value;
        }

        BottleModel.rotation = Quaternion.Euler(Mathf.Clamp(v.z, v.z > 0f ? 0f : -1f, v.z > 0f ? 1f : 0f) * MaxRotation.Value, 0f, Mathf.Clamp(v.x, v.x > 0f ? 0f : -1f, v.x > 0f ? 1f : 0f) * MaxRotation.Value);
    }


    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.CompareTag("Land")) {
            AudioManager.PlayOnMe(LandSound, Camera.main.transform);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ripple")) {
            Ripple r = other.GetComponentInParent<Ripple>();
            if (!myRipples.Contains(r)) {
                myRipples.Add(r);
            }
        }
        else if (other.CompareTag("Current")) {
            Current c = other.GetComponent<Current>();
            if (!myCurrents.Contains(c)) {
                myCurrents.Add(c);
                if (myCurrents.Count == 1) {
                    waterCurrentSound = RuntimeManager.CreateInstance(WaterCurrentSound);
                    waterCurrentSound.set3DAttributes(RuntimeUtils.To3DAttributes(myCurrents[0].transform));
                    waterCurrentSound.start();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Ripple")) {
            Ripple r = other.GetComponentInParent<Ripple>();
            if (myRipples.Contains(r)) {
                myRipples.Remove(r);
            }
        }
        else if (other.CompareTag("Current")) {
            Current c = other.GetComponent<Current>();
            if (myCurrents.Contains(c)) {
                myCurrents.Remove(c);
                if(myCurrents.Count == 0) {
                    waterCurrentSound.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
                }
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
