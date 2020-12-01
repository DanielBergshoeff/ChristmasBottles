#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CurrentPair`. Inherits from `AtomDrawer&lt;CurrentPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CurrentPairEvent))]
    public class CurrentPairEventDrawer : AtomDrawer<CurrentPairEvent> { }
}
#endif
