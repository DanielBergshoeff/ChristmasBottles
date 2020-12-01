#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Ripple`. Inherits from `AtomDrawer&lt;RippleEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(RippleEvent))]
    public class RippleEventDrawer : AtomDrawer<RippleEvent> { }
}
#endif
