#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Current`. Inherits from `AtomDrawer&lt;CurrentConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CurrentConstant))]
    public class CurrentConstantDrawer : VariableDrawer<CurrentConstant> { }
}
#endif
