using UnityEngine;

namespace Character
{
    public abstract class CharacterController : MonoBehaviour, ICharacterObservable
    {
        protected CharacterInputs CurrentCharacterInputs;

        public void SetInputs(CharacterInputs characterInputs)
        {
            CurrentCharacterInputs = characterInputs;
        }

        public Vector2 MovingDirection => transform.right * CurrentCharacterInputs.DesiredDirection.x;
    }
}