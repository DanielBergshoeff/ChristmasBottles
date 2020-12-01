using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `CurrentPair`. Inherits from `AtomEventReferenceListener&lt;CurrentPair, CurrentPairEvent, CurrentPairEventReference, CurrentPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/CurrentPair Event Reference Listener")]
    public sealed class CurrentPairEventReferenceListener : AtomEventReferenceListener<
        CurrentPair,
        CurrentPairEvent,
        CurrentPairEventReference,
        CurrentPairUnityEvent>
    { }
}
