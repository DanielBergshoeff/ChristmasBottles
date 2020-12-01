using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Ripple`. Inherits from `AtomEventInstancer&lt;Ripple, RippleEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Ripple Event Instancer")]
    public class RippleEventInstancer : AtomEventInstancer<Ripple, RippleEvent> { }
}
