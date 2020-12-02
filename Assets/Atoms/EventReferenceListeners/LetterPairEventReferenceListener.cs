using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `LetterPair`. Inherits from `AtomEventReferenceListener&lt;LetterPair, LetterPairEvent, LetterPairEventReference, LetterPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/LetterPair Event Reference Listener")]
    public sealed class LetterPairEventReferenceListener : AtomEventReferenceListener<
        LetterPair,
        LetterPairEvent,
        LetterPairEventReference,
        LetterPairUnityEvent>
    { }
}
