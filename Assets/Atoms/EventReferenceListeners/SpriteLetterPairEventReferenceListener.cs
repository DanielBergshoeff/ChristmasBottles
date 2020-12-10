using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `SpriteLetterPair`. Inherits from `AtomEventReferenceListener&lt;SpriteLetterPair, SpriteLetterPairEvent, SpriteLetterPairEventReference, SpriteLetterPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SpriteLetterPair Event Reference Listener")]
    public sealed class SpriteLetterPairEventReferenceListener : AtomEventReferenceListener<
        SpriteLetterPair,
        SpriteLetterPairEvent,
        SpriteLetterPairEventReference,
        SpriteLetterPairUnityEvent>
    { }
}
