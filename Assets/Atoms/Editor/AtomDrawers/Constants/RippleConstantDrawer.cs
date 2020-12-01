#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Ripple`. Inherits from `AtomDrawer&lt;RippleConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(RippleConstant))]
    public class RippleConstantDrawer : VariableDrawer<RippleConstant> { }
}
#endif
