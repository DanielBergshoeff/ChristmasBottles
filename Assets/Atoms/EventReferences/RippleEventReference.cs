using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Ripple`. Inherits from `AtomEventReference&lt;Ripple, RippleVariable, RippleEvent, RippleVariableInstancer, RippleEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class RippleEventReference : AtomEventReference<
        Ripple,
        RippleVariable,
        RippleEvent,
        RippleVariableInstancer,
        RippleEventInstancer>, IGetEvent 
    { }
}
