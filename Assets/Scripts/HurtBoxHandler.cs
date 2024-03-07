using System;
using UnityEngine;

namespace DefaultNamespace {
    public class HurtBoxHandler : MonoBehaviour {
        
        private void OnTriggerEnter2D(Collider2D other) {
            if (other.CompareTag("Enemy")) {
                other.GetComponent<LifeSystem>().TakeDamage(1);
            }
        }
    }
}