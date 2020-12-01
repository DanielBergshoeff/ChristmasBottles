#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Current`. Inherits from `AtomDrawer&lt;CurrentVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CurrentVariable))]
    public class CurrentVariableDrawer : VariableDrawer<CurrentVariable> { }
}
#endif
