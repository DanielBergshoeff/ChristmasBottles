using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Current`. Inherits from `AtomReference&lt;Current, CurrentPair, CurrentConstant, CurrentVariable, CurrentEvent, CurrentPairEvent, CurrentCurrentFunction, CurrentVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CurrentReference : AtomReference<
        Current,
        CurrentPair,
        CurrentConstant,
        CurrentVariable,
        CurrentEvent,
        CurrentPairEvent,
        CurrentCurrentFunction,
        CurrentVariableInstancer>, IEquatable<CurrentReference>
    {
        public CurrentReference() : base() { }
        public CurrentReference(Current value) : base(value) { }
        public bool Equals(CurrentReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Current other)
        {
            throw new NotImplementedException();
        }
    }
}
