using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Current`. Inherits from `AtomEventInstancer&lt;Current, CurrentEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Current Event Instancer")]
    public class CurrentEventInstancer : AtomEventInstancer<Current, CurrentEvent> { }
}
