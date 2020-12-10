using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Letter`. Inherits from `AtomEventReference&lt;Letter, LetterVariable, LetterEvent, LetterVariableInstancer, LetterEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LetterEventReference : AtomEventReference<
        Letter,
        LetterVariable,
        LetterEvent,
        LetterVariableInstancer,
        LetterEventInstancer>, IGetEvent 
    { }
}
