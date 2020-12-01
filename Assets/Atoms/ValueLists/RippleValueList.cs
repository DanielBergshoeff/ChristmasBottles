using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Ripple`. Inherits from `AtomValueList&lt;Ripple, RippleEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Ripple", fileName = "RippleValueList")]
    public sealed class RippleValueList : AtomValueList<Ripple, RippleEvent> { }
}
