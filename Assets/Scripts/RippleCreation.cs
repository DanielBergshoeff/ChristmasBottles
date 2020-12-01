using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleCreation : MonoBehaviour
{
    public GameObject RipplePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            StartRipple();
        }
    }

    private void StartRipple() {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 100f)){
            if (!hit.collider.CompareTag("Water"))
                return;

            GameObject go = Instantiate(RipplePrefab);
            go.transform.position = hit.point;
        }
    }
}
