#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SpriteLetterPair`. Inherits from `AtomEventEditor&lt;SpriteLetterPair, SpriteLetterPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SpriteLetterPairEvent))]
    public sealed class SpriteLetterPairEventEditor : AtomEventEditor<SpriteLetterPair, SpriteLetterPairEvent> { }
}
#endif
