using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Letter`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(LetterVariable))]
    public sealed class LetterVariableEditor : AtomVariableEditor<Letter, LetterPair> { }
}
