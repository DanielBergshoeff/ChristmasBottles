using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `SpriteLetter`. Inherits from `AtomEventReference&lt;SpriteLetter, SpriteLetterVariable, SpriteLetterEvent, SpriteLetterVariableInstancer, SpriteLetterEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpriteLetterEventReference : AtomEventReference<
        SpriteLetter,
        SpriteLetterVariable,
        SpriteLetterEvent,
        SpriteLetterVariableInstancer,
        SpriteLetterEventInstancer>, IGetEvent 
    { }
}
