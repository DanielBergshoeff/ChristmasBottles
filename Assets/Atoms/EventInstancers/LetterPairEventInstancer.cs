using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `LetterPair`. Inherits from `AtomEventInstancer&lt;LetterPair, LetterPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/LetterPair Event Instancer")]
    public class LetterPairEventInstancer : AtomEventInstancer<LetterPair, LetterPairEvent> { }
}
