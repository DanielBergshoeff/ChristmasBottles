using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Ripple&gt;`. Inherits from `IPair&lt;Ripple&gt;`.
    /// </summary>
    [Serializable]
    public struct RipplePair : IPair<Ripple>
    {
        public Ripple Item1 { get => _item1; set => _item1 = value; }
        public Ripple Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Ripple _item1;
        [SerializeField]
        private Ripple _item2;

        public void Deconstruct(out Ripple item1, out Ripple item2) { item1 = Item1; item2 = Item2; }
    }
}