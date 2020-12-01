#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Current`. Inherits from `AtomDrawer&lt;CurrentEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CurrentEvent))]
    public class CurrentEventDrawer : AtomDrawer<CurrentEvent> { }
}
#endif
