using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `RipplePair`. Inherits from `AtomEvent&lt;RipplePair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/RipplePair", fileName = "RipplePairEvent")]
    public sealed class RipplePairEvent : AtomEvent<RipplePair>
    {
    }
}
