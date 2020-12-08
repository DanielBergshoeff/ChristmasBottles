using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `SpriteLetterPair`. Inherits from `AtomEventReference&lt;SpriteLetterPair, SpriteLetterVariable, SpriteLetterPairEvent, SpriteLetterVariableInstancer, SpriteLetterPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpriteLetterPairEventReference : AtomEventReference<
        SpriteLetterPair,
        SpriteLetterVariable,
        SpriteLetterPairEvent,
        SpriteLetterVariableInstancer,
        SpriteLetterPairEventInstancer>, IGetEvent 
    { }
}
