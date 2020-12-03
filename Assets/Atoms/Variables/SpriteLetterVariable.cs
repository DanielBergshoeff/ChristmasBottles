using UnityEngine;
using System;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `SpriteLetter`. Inherits from `AtomVariable&lt;SpriteLetter, SpriteLetterPair, SpriteLetterEvent, SpriteLetterPairEvent, SpriteLetterSpriteLetterFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/SpriteLetter", fileName = "SpriteLetterVariable")]
    public sealed class SpriteLetterVariable : AtomVariable<SpriteLetter, SpriteLetterPair, SpriteLetterEvent, SpriteLetterPairEvent, SpriteLetterSpriteLetterFunction>
    {
        protected override bool ValueEquals(SpriteLetter other)
        {
            throw new NotImplementedException();
        }
    }
}
