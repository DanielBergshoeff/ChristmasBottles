#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Current`. Inherits from `AtomEventEditor&lt;Current, CurrentEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CurrentEvent))]
    public sealed class CurrentEventEditor : AtomEventEditor<Current, CurrentEvent> { }
}
#endif
