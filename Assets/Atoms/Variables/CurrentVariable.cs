using UnityEngine;
using System;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Current`. Inherits from `AtomVariable&lt;Current, CurrentPair, CurrentEvent, CurrentPairEvent, CurrentCurrentFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Current", fileName = "CurrentVariable")]
    public sealed class CurrentVariable : AtomVariable<Current, CurrentPair, CurrentEvent, CurrentPairEvent, CurrentCurrentFunction>
    {
        protected override bool ValueEquals(Current other)
        {
            throw new NotImplementedException();
        }
    }
}
