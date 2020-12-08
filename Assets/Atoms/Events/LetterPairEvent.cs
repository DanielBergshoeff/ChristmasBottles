using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `LetterPair`. Inherits from `AtomEvent&lt;LetterPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/LetterPair", fileName = "LetterPairEvent")]
    public sealed class LetterPairEvent : AtomEvent<LetterPair>
    {
    }
}
