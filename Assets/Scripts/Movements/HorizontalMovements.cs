using UnityEngine;

namespace DefaultNamespace {
    [RequireComponent(typeof(Rigidbody2D))]
    public class HorizontalMovements : MonoBehaviour {
        [SerializeField] private float _speed;
        private Rigidbody2D _rgb;
        int _direction;

        private void Awake() {
            _rgb = GetComponent<Rigidbody2D>();
        }
        
        private void Update() {
            Move(_direction);
        }

        [ContextMenu("MoveRight")]
        public void MoveRight() {
            _direction = 1;
        }

        [ContextMenu("MoveLeft")]
        public void MoveLeft() {
            _direction = -1;
        }

        public void StopMoving() {
            _direction = 0;
        }
        
        public void Move(int direction) {
            _rgb.velocity = new Vector2(direction * _speed, _rgb.velocity.y);
        }
        
    }
}