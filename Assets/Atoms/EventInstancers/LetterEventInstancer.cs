using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Letter`. Inherits from `AtomEventInstancer&lt;Letter, LetterEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Letter Event Instancer")]
    public class LetterEventInstancer : AtomEventInstancer<Letter, LetterEvent> { }
}
