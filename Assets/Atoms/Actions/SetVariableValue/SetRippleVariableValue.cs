using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Ripple`. Inherits from `SetVariableValue&lt;Ripple, RipplePair, RippleVariable, RippleConstant, RippleReference, RippleEvent, RipplePairEvent, RippleVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Ripple", fileName = "SetRippleVariableValue")]
    public sealed class SetRippleVariableValue : SetVariableValue<
        Ripple,
        RipplePair,
        RippleVariable,
        RippleConstant,
        RippleReference,
        RippleEvent,
        RipplePairEvent,
        RippleRippleFunction,
        RippleVariableInstancer>
    { }
}
