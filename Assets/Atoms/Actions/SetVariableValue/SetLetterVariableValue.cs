using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Letter`. Inherits from `SetVariableValue&lt;Letter, LetterPair, LetterVariable, LetterConstant, LetterReference, LetterEvent, LetterPairEvent, LetterVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Letter", fileName = "SetLetterVariableValue")]
    public sealed class SetLetterVariableValue : SetVariableValue<
        Letter,
        LetterPair,
        LetterVariable,
        LetterConstant,
        LetterReference,
        LetterEvent,
        LetterPairEvent,
        LetterLetterFunction,
        LetterVariableInstancer>
    { }
}
