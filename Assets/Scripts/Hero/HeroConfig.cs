using UnityEngine;

namespace Hero
{
    [CreateAssetMenu(menuName = "PLATFORMER-MEDIEVAL/Hero/MainConfig", fileName = "New Hero Config")]
    public class HeroConfig : ScriptableObject
    {
        [field: SerializeField] public float Speed  {get; private set;}= 3f; // скорость движения
        [field: SerializeField] public int Lives {get; private set;} = 5; // жизни
        [field: SerializeField] public float JumpForce {get; private set;} = 15f; // сила прыжка
    }
}