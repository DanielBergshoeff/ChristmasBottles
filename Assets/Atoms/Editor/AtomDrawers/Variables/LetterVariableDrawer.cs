#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Letter`. Inherits from `AtomDrawer&lt;LetterVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LetterVariable))]
    public class LetterVariableDrawer : VariableDrawer<LetterVariable> { }
}
#endif
