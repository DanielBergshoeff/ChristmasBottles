using UnityEngine;
using System;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Letter`. Inherits from `AtomVariable&lt;Letter, LetterPair, LetterEvent, LetterPairEvent, LetterLetterFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Letter", fileName = "LetterVariable")]
    public sealed class LetterVariable : AtomVariable<Letter, LetterPair, LetterEvent, LetterPairEvent, LetterLetterFunction>
    {
        protected override bool ValueEquals(Letter other)
        {
            throw new NotImplementedException();
        }
    }
}
