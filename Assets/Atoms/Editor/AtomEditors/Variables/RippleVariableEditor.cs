using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Ripple`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(RippleVariable))]
    public sealed class RippleVariableEditor : AtomVariableEditor<Ripple, RipplePair> { }
}
