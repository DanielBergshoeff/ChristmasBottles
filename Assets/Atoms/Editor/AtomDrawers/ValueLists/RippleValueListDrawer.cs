#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Ripple`. Inherits from `AtomDrawer&lt;RippleValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(RippleValueList))]
    public class RippleValueListDrawer : AtomDrawer<RippleValueList> { }
}
#endif
