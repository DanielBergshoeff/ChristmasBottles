using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Current`. Inherits from `AtomEventReference&lt;Current, CurrentVariable, CurrentEvent, CurrentVariableInstancer, CurrentEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CurrentEventReference : AtomEventReference<
        Current,
        CurrentVariable,
        CurrentEvent,
        CurrentVariableInstancer,
        CurrentEventInstancer>, IGetEvent 
    { }
}
