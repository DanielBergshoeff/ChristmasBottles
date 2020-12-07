using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `SpriteLetter`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SpriteLetterVariable))]
    public sealed class SpriteLetterVariableEditor : AtomVariableEditor<SpriteLetter, SpriteLetterPair> { }
}
