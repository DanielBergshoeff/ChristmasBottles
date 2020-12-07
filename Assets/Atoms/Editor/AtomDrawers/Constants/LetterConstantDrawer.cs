#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Letter`. Inherits from `AtomDrawer&lt;LetterConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LetterConstant))]
    public class LetterConstantDrawer : VariableDrawer<LetterConstant> { }
}
#endif
