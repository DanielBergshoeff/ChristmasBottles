using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `CurrentPair`. Inherits from `AtomEvent&lt;CurrentPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/CurrentPair", fileName = "CurrentPairEvent")]
    public sealed class CurrentPairEvent : AtomEvent<CurrentPair>
    {
    }
}
