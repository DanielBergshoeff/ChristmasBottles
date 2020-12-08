using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleBreakVisuals : MonoBehaviour
{
    public Renderer MyRenderer;
    public List<Material> MatPerPhase;

    public void OnBreakChange(int phase) {
        MyRenderer.material = MatPerPhase[Mathf.Clamp(phase, 0, MatPerPhase.Count - 1)];
    }
}
