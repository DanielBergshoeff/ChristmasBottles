using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `SpriteLetter`. Inherits from `SetVariableValue&lt;SpriteLetter, SpriteLetterPair, SpriteLetterVariable, SpriteLetterConstant, SpriteLetterReference, SpriteLetterEvent, SpriteLetterPairEvent, SpriteLetterVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/SpriteLetter", fileName = "SetSpriteLetterVariableValue")]
    public sealed class SetSpriteLetterVariableValue : SetVariableValue<
        SpriteLetter,
        SpriteLetterPair,
        SpriteLetterVariable,
        SpriteLetterConstant,
        SpriteLetterReference,
        SpriteLetterEvent,
        SpriteLetterPairEvent,
        SpriteLetterSpriteLetterFunction,
        SpriteLetterVariableInstancer>
    { }
}
