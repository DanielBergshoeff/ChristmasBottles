using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `SpriteLetter`. Inherits from `AtomVariableInstancer&lt;SpriteLetterVariable, SpriteLetterPair, SpriteLetter, SpriteLetterEvent, SpriteLetterPairEvent, SpriteLetterSpriteLetterFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/SpriteLetter Variable Instancer")]
    public class SpriteLetterVariableInstancer : AtomVariableInstancer<
        SpriteLetterVariable,
        SpriteLetterPair,
        SpriteLetter,
        SpriteLetterEvent,
        SpriteLetterPairEvent,
        SpriteLetterSpriteLetterFunction>
    { }
}
