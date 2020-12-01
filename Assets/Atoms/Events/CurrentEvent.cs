using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Current`. Inherits from `AtomEvent&lt;Current&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Current", fileName = "CurrentEvent")]
    public sealed class CurrentEvent : AtomEvent<Current>
    {
    }
}
