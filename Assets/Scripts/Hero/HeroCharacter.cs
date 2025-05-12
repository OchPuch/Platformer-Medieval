using UnityEngine;
using CharacterController = Character.CharacterController;

namespace Hero
{
    public class HeroCharacter : CharacterController
    {
        [SerializeField] private Rigidbody2D _rb; 
        private HeroConfig _heroConfig;
        private bool _isGrounded = false;
        
        public void Init(HeroConfig heroConfig)
        {
            _heroConfig = heroConfig;
        }
        
        private void Awake()
        {
            _rb ??= GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            CheckGround();
        }

        private void Update()
        {
            if (CurrentCharacterInputs.DesiredDirection.x != 0)
            {
                Run();
            }

            if (_isGrounded && CurrentCharacterInputs.JumpRequest)
            {
                Jump();
            }
        }

        private void Run()
        {
            _rb.linearVelocityX = MovingDirection.x * _heroConfig.Speed;
        }

        private void Jump()
        {
            _rb.AddForce(transform.up * _heroConfig.JumpForce, ForceMode2D.Impulse);
        }

        private void CheckGround()
        {
            Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
            _isGrounded = collider.Length > 1;
        }

    }
}