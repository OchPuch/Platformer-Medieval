using System;
using Character;
using UnityEngine;

namespace Hero
{
    public class HeroPlayer : MonoBehaviour, IDamageable
    {
        private HeroConfig _heroConfig;
        private HeroCharacter _heroCharacter;

        private int _health;
        
        public void Init(HeroConfig heroConfig, HeroCharacter heroCharacter)
        {
            _heroCharacter = heroCharacter;
            _heroConfig = heroConfig;

            _health = heroConfig.Lives;
        }

        private void Update()
        {
            _heroCharacter.SetInputs(new CharacterInputs()
            {
                DesiredDirection = new Vector2(Input.GetAxis("Horizontal"), 0),
                JumpRequest = Input.GetButtonDown("Jump")
            });
        }
        
        public void Damage(int value)
        {
            if (value <= 0) return;
            _health -= value;
            if (_health <= 0)
            {
                Kill();
            }
        }

        public void Kill()
        {
            Debug.Log("Kill");
        }
        
        
    }
}