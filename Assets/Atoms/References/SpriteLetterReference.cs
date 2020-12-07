using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `SpriteLetter`. Inherits from `AtomReference&lt;SpriteLetter, SpriteLetterPair, SpriteLetterConstant, SpriteLetterVariable, SpriteLetterEvent, SpriteLetterPairEvent, SpriteLetterSpriteLetterFunction, SpriteLetterVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpriteLetterReference : AtomReference<
        SpriteLetter,
        SpriteLetterPair,
        SpriteLetterConstant,
        SpriteLetterVariable,
        SpriteLetterEvent,
        SpriteLetterPairEvent,
        SpriteLetterSpriteLetterFunction,
        SpriteLetterVariableInstancer>, IEquatable<SpriteLetterReference>
    {
        public SpriteLetterReference() : base() { }
        public SpriteLetterReference(SpriteLetter value) : base(value) { }
        public bool Equals(SpriteLetterReference other) { return base.Equals(other); }
        protected override bool ValueEquals(SpriteLetter other)
        {
            throw new NotImplementedException();
        }
    }
}
