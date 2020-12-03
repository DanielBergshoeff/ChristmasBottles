using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `LetterPair`. Inherits from `AtomEventReference&lt;LetterPair, LetterVariable, LetterPairEvent, LetterVariableInstancer, LetterPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LetterPairEventReference : AtomEventReference<
        LetterPair,
        LetterVariable,
        LetterPairEvent,
        LetterVariableInstancer,
        LetterPairEventInstancer>, IGetEvent 
    { }
}
