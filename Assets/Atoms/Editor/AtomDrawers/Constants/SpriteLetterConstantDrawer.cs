#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `SpriteLetter`. Inherits from `AtomDrawer&lt;SpriteLetterConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpriteLetterConstant))]
    public class SpriteLetterConstantDrawer : VariableDrawer<SpriteLetterConstant> { }
}
#endif
