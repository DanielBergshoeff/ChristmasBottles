#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SpriteLetter`. Inherits from `AtomDrawer&lt;SpriteLetterEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpriteLetterEvent))]
    public class SpriteLetterEventDrawer : AtomDrawer<SpriteLetterEvent> { }
}
#endif
