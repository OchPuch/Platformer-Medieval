using UnityEngine;

namespace Character
{
    public interface ICharacterObservable
    {
        public Vector2 MovingDirection { get; }
    }
}