using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `CurrentPair`. Inherits from `AtomEventReference&lt;CurrentPair, CurrentVariable, CurrentPairEvent, CurrentVariableInstancer, CurrentPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CurrentPairEventReference : AtomEventReference<
        CurrentPair,
        CurrentVariable,
        CurrentPairEvent,
        CurrentVariableInstancer,
        CurrentPairEventInstancer>, IGetEvent 
    { }
}
