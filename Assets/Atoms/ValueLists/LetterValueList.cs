using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Letter`. Inherits from `AtomValueList&lt;Letter, LetterEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Letter", fileName = "LetterValueList")]
    public sealed class LetterValueList : AtomValueList<Letter, LetterEvent> { }
}
