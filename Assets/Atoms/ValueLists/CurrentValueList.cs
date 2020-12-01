using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Current`. Inherits from `AtomValueList&lt;Current, CurrentEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Current", fileName = "CurrentValueList")]
    public sealed class CurrentValueList : AtomValueList<Current, CurrentEvent> { }
}
