using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Current`. Inherits from `AtomEventReferenceListener&lt;Current, CurrentEvent, CurrentEventReference, CurrentUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Current Event Reference Listener")]
    public sealed class CurrentEventReferenceListener : AtomEventReferenceListener<
        Current,
        CurrentEvent,
        CurrentEventReference,
        CurrentUnityEvent>
    { }
}
