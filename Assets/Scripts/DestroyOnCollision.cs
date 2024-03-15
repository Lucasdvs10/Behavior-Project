using UnityEngine;

namespace DefaultNamespace {
    public class DestroyOnCollision : MonoBehaviour {
        [SerializeField] private string _tagToDetect;
        
        private void OnTriggerEnter2D(Collider2D other) {
            if(other.CompareTag(_tagToDetect))
                Destroy(gameObject);
        }
    }
}