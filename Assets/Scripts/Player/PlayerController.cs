using Interfaces;
using Singleton;
using Statics;
using UnityEngine;

namespace Player
{
    public class PlayerController : Singleton<PlayerController>, IMovable
    {
        public float MoveSpeed { get; set; } = 5.5f;
        public bool isFall;

        private Rigidbody _rigidbody;
        private const float AxisY = -.3f;
        private float _vertical;
        private float _horizontal;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            _horizontal = Input.GetAxisRaw(StringCache.Horizontal);
            _vertical = Input.GetAxisRaw(StringCache.Vertical);

            isFall = transform.position.y < AxisY;

            if (isFall)
            {
                _rigidbody.isKinematic = true;
                transform.GetComponent<PlayerController>().enabled = false;
            }
        }

        private void PlayerRotation()
        {
            var movement = new Vector3(_horizontal, 0, _vertical).normalized;
            if (movement == Vector3.zero) return;
            
            var targetRotation = Quaternion.LookRotation(movement);

            targetRotation = Quaternion.RotateTowards
            (
                transform.rotation,
                targetRotation,
                360 * Time.fixedDeltaTime
            );

            _rigidbody.MoveRotation(targetRotation);
        }

        private void FixedUpdate()
        {    
            PlayerMovement();
            PlayerRotation();
        }

        public void PlayerMovement()
        {
            var totalSpeed = MoveSpeed * Time.deltaTime;
            transform.Translate
            (
                new Vector3(_horizontal, 0f, _vertical) * totalSpeed,
                Space.World
            );
        }
    }
}
