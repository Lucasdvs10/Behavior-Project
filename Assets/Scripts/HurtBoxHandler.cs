using System;
using UnityEngine;

namespace DefaultNamespace {
    public class HurtBoxHandler : MonoBehaviour {
        [SerializeField] private string _tagToDetect;
        
        private void OnTriggerEnter2D(Collider2D other) {
            if (other.CompareTag(_tagToDetect)) {
                other.GetComponent<LifeSystem>().TakeDamage(1);
            }
        }
    }
}