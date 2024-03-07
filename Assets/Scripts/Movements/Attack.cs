using UnityEngine;

namespace DefaultNamespace {
    public class Attack : MonoBehaviour {
        Transform _hurtBoxTransform;
        Animator _animator;

        private void Awake() {
            _hurtBoxTransform = transform.GetChild(0);
            _animator = GetComponent<Animator>();
        }

        [ContextMenu("StartAttackAnimation")]
        public void StartAttackAnimation() {
            _animator.Play("Attack1");
        }
        
        
    }
}