using System;
using UnityEngine;

namespace DefaultNamespace {
    public class HurtBoxHandler : MonoBehaviour {
        [SerializeField] private string _tagToDetect;

        public void ActivateAttackHitbox() {
            var hits = Physics2D.OverlapCircle(new Vector2(transform.position.x + 1f, transform.position.y), 0.5f);
            
            if (hits != null) {
                if (hits.CompareTag(_tagToDetect)) {
                    hits.GetComponent<LifeSystem>().TakeDamage(1);
                }
            }
        }
    }
}