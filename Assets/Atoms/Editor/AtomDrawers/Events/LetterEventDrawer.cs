#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Letter`. Inherits from `AtomDrawer&lt;LetterEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LetterEvent))]
    public class LetterEventDrawer : AtomDrawer<LetterEvent> { }
}
#endif
