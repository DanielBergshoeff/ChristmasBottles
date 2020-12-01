using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Current`. Inherits from `SetVariableValue&lt;Current, CurrentPair, CurrentVariable, CurrentConstant, CurrentReference, CurrentEvent, CurrentPairEvent, CurrentVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Current", fileName = "SetCurrentVariableValue")]
    public sealed class SetCurrentVariableValue : SetVariableValue<
        Current,
        CurrentPair,
        CurrentVariable,
        CurrentConstant,
        CurrentReference,
        CurrentEvent,
        CurrentPairEvent,
        CurrentCurrentFunction,
        CurrentVariableInstancer>
    { }
}
