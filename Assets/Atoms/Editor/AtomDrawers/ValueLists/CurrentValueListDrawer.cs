#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Current`. Inherits from `AtomDrawer&lt;CurrentValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CurrentValueList))]
    public class CurrentValueListDrawer : AtomDrawer<CurrentValueList> { }
}
#endif
