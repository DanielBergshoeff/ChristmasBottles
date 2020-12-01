using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Ripple`. Inherits from `AtomReference&lt;Ripple, RipplePair, RippleConstant, RippleVariable, RippleEvent, RipplePairEvent, RippleRippleFunction, RippleVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class RippleReference : AtomReference<
        Ripple,
        RipplePair,
        RippleConstant,
        RippleVariable,
        RippleEvent,
        RipplePairEvent,
        RippleRippleFunction,
        RippleVariableInstancer>, IEquatable<RippleReference>
    {
        public RippleReference() : base() { }
        public RippleReference(Ripple value) : base(value) { }
        public bool Equals(RippleReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Ripple other)
        {
            throw new NotImplementedException();
        }
    }
}
