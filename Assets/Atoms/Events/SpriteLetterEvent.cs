using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `SpriteLetter`. Inherits from `AtomEvent&lt;SpriteLetter&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SpriteLetter", fileName = "SpriteLetterEvent")]
    public sealed class SpriteLetterEvent : AtomEvent<SpriteLetter>
    {
    }
}
