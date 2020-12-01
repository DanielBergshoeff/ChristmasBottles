using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `RipplePair`. Inherits from `AtomEventReference&lt;RipplePair, RippleVariable, RipplePairEvent, RippleVariableInstancer, RipplePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class RipplePairEventReference : AtomEventReference<
        RipplePair,
        RippleVariable,
        RipplePairEvent,
        RippleVariableInstancer,
        RipplePairEventInstancer>, IGetEvent 
    { }
}
