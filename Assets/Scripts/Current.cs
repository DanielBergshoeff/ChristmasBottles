using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Current : MonoBehaviour
{
    public CurrentValueList AllCurrents; 
    public FloatReference Speed;
    public FloatReference MaxSpeed;

    private void Awake() {
        AllCurrents.Add(this);
    }

    private void OnDestroy() {
        AllCurrents.Remove(this);
    }
}
