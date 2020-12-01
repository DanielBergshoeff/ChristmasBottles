using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Current`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(CurrentVariable))]
    public sealed class CurrentVariableEditor : AtomVariableEditor<Current, CurrentPair> { }
}
