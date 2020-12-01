using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Current&gt;`. Inherits from `IPair&lt;Current&gt;`.
    /// </summary>
    [Serializable]
    public struct CurrentPair : IPair<Current>
    {
        public Current Item1 { get => _item1; set => _item1 = value; }
        public Current Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Current _item1;
        [SerializeField]
        private Current _item2;

        public void Deconstruct(out Current item1, out Current item2) { item1 = Item1; item2 = Item2; }
    }
}