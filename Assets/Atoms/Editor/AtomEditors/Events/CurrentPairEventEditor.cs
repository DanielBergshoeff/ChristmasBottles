#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CurrentPair`. Inherits from `AtomEventEditor&lt;CurrentPair, CurrentPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CurrentPairEvent))]
    public sealed class CurrentPairEventEditor : AtomEventEditor<CurrentPair, CurrentPairEvent> { }
}
#endif
