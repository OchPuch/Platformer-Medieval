using System;
using UnityEngine;

namespace Hero
{
    public class HeroBootstrap : MonoBehaviour
    {
        [SerializeField] private HeroConfig _heroConfig;
        [SerializeField] private HeroPlayer _heroPlayer;
        [SerializeField] private HeroCharacter _heroCharacter;
        [SerializeField] private HeroView _heroView;

        private void Awake()
        {
            _heroCharacter.Init(_heroConfig);
            _heroPlayer.Init(_heroConfig, _heroCharacter);
            _heroView.Init(_heroCharacter);
        }
    }
}