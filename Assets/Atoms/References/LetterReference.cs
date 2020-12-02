using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Letter`. Inherits from `AtomReference&lt;Letter, LetterPair, LetterConstant, LetterVariable, LetterEvent, LetterPairEvent, LetterLetterFunction, LetterVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LetterReference : AtomReference<
        Letter,
        LetterPair,
        LetterConstant,
        LetterVariable,
        LetterEvent,
        LetterPairEvent,
        LetterLetterFunction,
        LetterVariableInstancer>, IEquatable<LetterReference>
    {
        public LetterReference() : base() { }
        public LetterReference(Letter value) : base(value) { }
        public bool Equals(LetterReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Letter other)
        {
            throw new NotImplementedException();
        }
    }
}
