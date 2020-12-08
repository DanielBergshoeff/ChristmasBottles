using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `SpriteLetter`. Inherits from `AtomEventInstancer&lt;SpriteLetter, SpriteLetterEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/SpriteLetter Event Instancer")]
    public class SpriteLetterEventInstancer : AtomEventInstancer<SpriteLetter, SpriteLetterEvent> { }
}
