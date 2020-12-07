using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Letter`. Inherits from `UnityEvent&lt;Letter&gt;`.
    /// </summary>
    [Serializable]
    public sealed class LetterUnityEvent : UnityEvent<Letter> { }
}
