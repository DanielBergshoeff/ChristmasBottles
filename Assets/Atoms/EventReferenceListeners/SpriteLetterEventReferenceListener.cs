using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `SpriteLetter`. Inherits from `AtomEventReferenceListener&lt;SpriteLetter, SpriteLetterEvent, SpriteLetterEventReference, SpriteLetterUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SpriteLetter Event Reference Listener")]
    public sealed class SpriteLetterEventReferenceListener : AtomEventReferenceListener<
        SpriteLetter,
        SpriteLetterEvent,
        SpriteLetterEventReference,
        SpriteLetterUnityEvent>
    { }
}
