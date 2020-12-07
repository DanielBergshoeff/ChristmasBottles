#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SpriteLetter`. Inherits from `AtomEventEditor&lt;SpriteLetter, SpriteLetterEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SpriteLetterEvent))]
    public sealed class SpriteLetterEventEditor : AtomEventEditor<SpriteLetter, SpriteLetterEvent> { }
}
#endif
