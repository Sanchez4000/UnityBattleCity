using System;
using UnityEngine;
using Assets.Code.Game.Enums;

namespace Assets.Code.Game.Tank
{
    [Serializable]
    public class MovementController
    {
        [SerializeField] private float _speed;
        private Rigidbody2D _rigidbody;
        private Transform _tankTransform;
        private Vector3 _movementDirection = Vector3.zero;

        public MovementController(Transform tankTransform, Rigidbody2D rigidbody)
        {
            _tankTransform = tankTransform;
            _rigidbody = rigidbody;
        }
        public void Update()
        {
            Vector3 newPosition = _tankTransform.position + _movementDirection * _speed * Time.fixedDeltaTime;
            _rigidbody.MovePosition(newPosition);
            _movementDirection = Vector3.zero;
        }
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                {
                    _movementDirection = Vector3.up;
                    break;
                }
                case Direction.Down:
                {
                    _movementDirection = Vector3.down;
                    break;
                }
                case Direction.Left:
                {
                    _movementDirection = Vector3.left;
                    break;
                }
                case Direction.Right:
                {
                    _movementDirection = Vector3.right;
                    break;
                }
            }
        }
    }
}