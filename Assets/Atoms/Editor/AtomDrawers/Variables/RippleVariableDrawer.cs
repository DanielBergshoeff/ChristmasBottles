#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Ripple`. Inherits from `AtomDrawer&lt;RippleVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(RippleVariable))]
    public class RippleVariableDrawer : VariableDrawer<RippleVariable> { }
}
#endif
