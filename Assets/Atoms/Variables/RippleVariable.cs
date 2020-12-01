using UnityEngine;
using System;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Ripple`. Inherits from `AtomVariable&lt;Ripple, RipplePair, RippleEvent, RipplePairEvent, RippleRippleFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Ripple", fileName = "RippleVariable")]
    public sealed class RippleVariable : AtomVariable<Ripple, RipplePair, RippleEvent, RipplePairEvent, RippleRippleFunction>
    {
        protected override bool ValueEquals(Ripple other)
        {
            throw new NotImplementedException();
        }
    }
}
