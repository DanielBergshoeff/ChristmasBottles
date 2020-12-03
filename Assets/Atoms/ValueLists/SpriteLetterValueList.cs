using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `SpriteLetter`. Inherits from `AtomValueList&lt;SpriteLetter, SpriteLetterEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/SpriteLetter", fileName = "SpriteLetterValueList")]
    public sealed class SpriteLetterValueList : AtomValueList<SpriteLetter, SpriteLetterEvent> { }
}
