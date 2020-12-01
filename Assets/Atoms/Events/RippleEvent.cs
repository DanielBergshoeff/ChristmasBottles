using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Ripple`. Inherits from `AtomEvent&lt;Ripple&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Ripple", fileName = "RippleEvent")]
    public sealed class RippleEvent : AtomEvent<Ripple>
    {
    }
}
