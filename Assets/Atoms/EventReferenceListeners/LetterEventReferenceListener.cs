using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Letter`. Inherits from `AtomEventReferenceListener&lt;Letter, LetterEvent, LetterEventReference, LetterUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Letter Event Reference Listener")]
    public sealed class LetterEventReferenceListener : AtomEventReferenceListener<
        Letter,
        LetterEvent,
        LetterEventReference,
        LetterUnityEvent>
    { }
}
