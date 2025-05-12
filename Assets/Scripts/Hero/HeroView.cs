using Character;
using UnityEngine;

namespace Hero
{
    public class HeroView : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        private ICharacterObservable _characterObservable;
        
        public void Init(ICharacterObservable characterObservable)
        {
            _characterObservable = characterObservable;
        }
        
        private void Awake()
        {
            _spriteRenderer ??= GetComponentInChildren<SpriteRenderer>();
        }

        private void Update()
        {
            _spriteRenderer.flipX = _characterObservable.MovingDirection.x < 0.0f;
        }
    }
}