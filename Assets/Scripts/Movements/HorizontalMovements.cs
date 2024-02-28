using UnityEngine;

namespace DefaultNamespace {
    [RequireComponent(typeof(Rigidbody2D))]
    public class HorizontalMovements : MonoBehaviour {
        [SerializeField] private float _speed;
        private Rigidbody2D _rgb;

        private void Awake() {
            _rgb = GetComponent<Rigidbody2D>();
        }

        public void MoveRight() {
            Move(1);
        }

        
        public void MoveLeft() {
            Move(-1);
        }
        
        public void Move(float direction) {
            _rgb.velocity = Vector2.right * (direction * _speed);
        }
        
    }
}