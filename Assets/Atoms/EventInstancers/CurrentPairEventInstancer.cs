using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `CurrentPair`. Inherits from `AtomEventInstancer&lt;CurrentPair, CurrentPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/CurrentPair Event Instancer")]
    public class CurrentPairEventInstancer : AtomEventInstancer<CurrentPair, CurrentPairEvent> { }
}
