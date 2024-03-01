using UnityEngine;

namespace DefaultNamespace {
    [RequireComponent(typeof(Rigidbody2D))]
    public class Jump : MonoBehaviour {
        [SerializeField] private Vector2 _jumpForce;
        private Rigidbody2D _rgb;
        private bool _isJumping;

        private void Awake() {
            _rgb = GetComponent<Rigidbody2D>();
        }

        private void OnCollisionEnter2D(Collision2D other) {
            if (other.gameObject.CompareTag("Ground")) {
                _isJumping = false;
            }
        }

        public void JumpAction() {
            if (_isJumping) return;
            
            _rgb.AddForce(_jumpForce, ForceMode2D.Impulse);
            _isJumping = true;
        }
        
    }
}