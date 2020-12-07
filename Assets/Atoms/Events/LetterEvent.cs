using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Letter`. Inherits from `AtomEvent&lt;Letter&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Letter", fileName = "LetterEvent")]
    public sealed class LetterEvent : AtomEvent<Letter>
    {
    }
}
