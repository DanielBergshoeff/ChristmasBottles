#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SpriteLetterPair`. Inherits from `AtomDrawer&lt;SpriteLetterPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpriteLetterPairEvent))]
    public class SpriteLetterPairEventDrawer : AtomDrawer<SpriteLetterPairEvent> { }
}
#endif
