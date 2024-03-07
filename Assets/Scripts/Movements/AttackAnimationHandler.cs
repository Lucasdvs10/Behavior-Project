using UnityEngine;

namespace DefaultNamespace {
    public class AttackAnimationHandler : MonoBehaviour {
        Animator _animator;

        private void Awake() {
            _animator = GetComponent<Animator>();
        }

        [ContextMenu("StartAttackAnimation")]
        public void StartAttackAnimation() {
            _animator.Play("Attack1");
        }
        
        
    }
}