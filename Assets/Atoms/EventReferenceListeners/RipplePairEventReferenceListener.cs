using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `RipplePair`. Inherits from `AtomEventReferenceListener&lt;RipplePair, RipplePairEvent, RipplePairEventReference, RipplePairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/RipplePair Event Reference Listener")]
    public sealed class RipplePairEventReferenceListener : AtomEventReferenceListener<
        RipplePair,
        RipplePairEvent,
        RipplePairEventReference,
        RipplePairUnityEvent>
    { }
}
