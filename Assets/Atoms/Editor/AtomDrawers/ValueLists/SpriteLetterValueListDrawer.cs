#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `SpriteLetter`. Inherits from `AtomDrawer&lt;SpriteLetterValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpriteLetterValueList))]
    public class SpriteLetterValueListDrawer : AtomDrawer<SpriteLetterValueList> { }
}
#endif
