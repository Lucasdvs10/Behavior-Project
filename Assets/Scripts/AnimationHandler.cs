using UnityEngine;

namespace DefaultNamespace {
    public class AnimationHandler : MonoBehaviour {
        private Animator _animator;

        private void Awake() {
            _animator = GetComponent<Animator>();
        }
        
        public void SetGroundedFlag(bool isGrounded) {
            _animator.SetBool("Grounded", isGrounded);
        }

        public void SetAnimationState(int animationState) {
            _animator.SetInteger("AnimationState", animationState);
        }
        
        public void SetAnimation(string animationName) {
            _animator.Play(animationName);
        }

        public void FlipSprite(int direction) {
            transform.rotation = Quaternion.Euler(1,direction,1);
        }
        
        private void OnCollisionEnter2D(Collision2D other) {
            if (other.gameObject.CompareTag("Ground")) {
                SetGroundedFlag(true);
                SetAnimation("Idle");
            }
        }
    }
}