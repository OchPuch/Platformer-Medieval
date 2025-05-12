using System;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private int _damage;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent<IDamageable>(out var damageable))
        {
            damageable.Damage(_damage);
        }
    }
}