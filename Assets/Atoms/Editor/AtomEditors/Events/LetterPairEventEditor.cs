#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `LetterPair`. Inherits from `AtomEventEditor&lt;LetterPair, LetterPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(LetterPairEvent))]
    public sealed class LetterPairEventEditor : AtomEventEditor<LetterPair, LetterPairEvent> { }
}
#endif
