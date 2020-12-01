#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Ripple`. Inherits from `AtomEventEditor&lt;Ripple, RippleEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(RippleEvent))]
    public sealed class RippleEventEditor : AtomEventEditor<Ripple, RippleEvent> { }
}
#endif
