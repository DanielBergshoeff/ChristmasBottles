#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Letter`. Inherits from `AtomEventEditor&lt;Letter, LetterEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(LetterEvent))]
    public sealed class LetterEventEditor : AtomEventEditor<Letter, LetterEvent> { }
}
#endif
