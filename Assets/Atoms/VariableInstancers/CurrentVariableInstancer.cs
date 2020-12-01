using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Current`. Inherits from `AtomVariableInstancer&lt;CurrentVariable, CurrentPair, Current, CurrentEvent, CurrentPairEvent, CurrentCurrentFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Current Variable Instancer")]
    public class CurrentVariableInstancer : AtomVariableInstancer<
        CurrentVariable,
        CurrentPair,
        Current,
        CurrentEvent,
        CurrentPairEvent,
        CurrentCurrentFunction>
    { }
}
