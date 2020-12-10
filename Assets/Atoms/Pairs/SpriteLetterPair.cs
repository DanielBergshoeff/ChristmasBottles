using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;SpriteLetter&gt;`. Inherits from `IPair&lt;SpriteLetter&gt;`.
    /// </summary>
    [Serializable]
    public struct SpriteLetterPair : IPair<SpriteLetter>
    {
        public SpriteLetter Item1 { get => _item1; set => _item1 = value; }
        public SpriteLetter Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private SpriteLetter _item1;
        [SerializeField]
        private SpriteLetter _item2;

        public void Deconstruct(out SpriteLetter item1, out SpriteLetter item2) { item1 = Item1; item2 = Item2; }
    }
}