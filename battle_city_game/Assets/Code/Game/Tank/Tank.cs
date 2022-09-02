using UnityEngine;
using Assets.Code.Game.Interfaces;
using Assets.Code.Game.Enums;

namespace Assets.Code.Game.Tank
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Tank : MonoBehaviour, IMovement
    {
        [SerializeField] private MovementController _moveController = null;

        private void Start()
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

            _moveController = new MovementController(transform, rigidbody);
        }
        private void FixedUpdate()
        {
            _moveController.Update();
        }


        public void Move(Direction direction)
        {
            _moveController.Move(direction);
        }
    }
}