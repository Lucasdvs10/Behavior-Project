using UnityEngine;

namespace DefaultNamespace {
    [RequireComponent(typeof(Rigidbody2D))]
    public class Jump : MonoBehaviour {
        [SerializeField] private Vector2 _jumpForce;
        private Rigidbody2D _rgb;

        private void Awake() {
            _rgb = GetComponent<Rigidbody2D>();
        }


        public void JumpAction() {
            _rgb.AddForce(_jumpForce, ForceMode2D.Impulse);
        }
        
    }
}