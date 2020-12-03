using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Letter`. Inherits from `AtomVariableInstancer&lt;LetterVariable, LetterPair, Letter, LetterEvent, LetterPairEvent, LetterLetterFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Letter Variable Instancer")]
    public class LetterVariableInstancer : AtomVariableInstancer<
        LetterVariable,
        LetterPair,
        Letter,
        LetterEvent,
        LetterPairEvent,
        LetterLetterFunction>
    { }
}
