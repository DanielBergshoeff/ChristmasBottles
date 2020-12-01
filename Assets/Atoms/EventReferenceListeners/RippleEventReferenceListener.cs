using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Ripple`. Inherits from `AtomEventReferenceListener&lt;Ripple, RippleEvent, RippleEventReference, RippleUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Ripple Event Reference Listener")]
    public sealed class RippleEventReferenceListener : AtomEventReferenceListener<
        Ripple,
        RippleEvent,
        RippleEventReference,
        RippleUnityEvent>
    { }
}
