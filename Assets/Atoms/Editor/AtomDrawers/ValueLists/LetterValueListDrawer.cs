#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Letter`. Inherits from `AtomDrawer&lt;LetterValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(LetterValueList))]
    public class LetterValueListDrawer : AtomDrawer<LetterValueList> { }
}
#endif
