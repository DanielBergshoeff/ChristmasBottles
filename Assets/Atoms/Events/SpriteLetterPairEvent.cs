using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `SpriteLetterPair`. Inherits from `AtomEvent&lt;SpriteLetterPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SpriteLetterPair", fileName = "SpriteLetterPairEvent")]
    public sealed class SpriteLetterPairEvent : AtomEvent<SpriteLetterPair>
    {
    }
}
