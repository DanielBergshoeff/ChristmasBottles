using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Letter&gt;`. Inherits from `IPair&lt;Letter&gt;`.
    /// </summary>
    [Serializable]
    public struct LetterPair : IPair<Letter>
    {
        public Letter Item1 { get => _item1; set => _item1 = value; }
        public Letter Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Letter _item1;
        [SerializeField]
        private Letter _item2;

        public void Deconstruct(out Letter item1, out Letter item2) { item1 = Item1; item2 = Item2; }
    }
}