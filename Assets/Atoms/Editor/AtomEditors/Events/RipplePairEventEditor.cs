#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `RipplePair`. Inherits from `AtomEventEditor&lt;RipplePair, RipplePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(RipplePairEvent))]
    public sealed class RipplePairEventEditor : AtomEventEditor<RipplePair, RipplePairEvent> { }
}
#endif
