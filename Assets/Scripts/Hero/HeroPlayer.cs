using System;
using Character;
using UnityEngine;

namespace Hero
{
    public class HeroPlayer : MonoBehaviour, IDamageable
    {
        private HeroConfig _heroConfig;
        private HeroCharacter _heroCharacter;
        public void Init(HeroConfig heroConfig, HeroCharacter heroCharacter)
        {
            _heroCharacter = heroCharacter;
            _heroConfig = heroConfig;
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
            Debug.Log($"damage {value}");
        }
    }
}