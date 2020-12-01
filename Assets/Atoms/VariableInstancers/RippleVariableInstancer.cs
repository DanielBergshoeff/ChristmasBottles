using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Ripple`. Inherits from `AtomVariableInstancer&lt;RippleVariable, RipplePair, Ripple, RippleEvent, RipplePairEvent, RippleRippleFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Ripple Variable Instancer")]
    public class RippleVariableInstancer : AtomVariableInstancer<
        RippleVariable,
        RipplePair,
        Ripple,
        RippleEvent,
        RipplePairEvent,
        RippleRippleFunction>
    { }
}
