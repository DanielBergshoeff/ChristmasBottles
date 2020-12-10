#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `SpriteLetter`. Inherits from `AtomDrawer&lt;SpriteLetterVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpriteLetterVariable))]
    public class SpriteLetterVariableDrawer : VariableDrawer<SpriteLetterVariable> { }
}
#endif
