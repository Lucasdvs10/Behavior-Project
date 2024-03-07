using UnityEngine;

namespace Scripts.EventSystem {
    public class OnTriggerEnterEvent : MonoBehaviour {
        public SOBaseGlobalEvent onCollisionEnterEvent;
        public string TargetTag;

        private void OnTriggerEnter2D(Collider2D other) {
            if (other.CompareTag(TargetTag)) {
                onCollisionEnterEvent.InvokeEvent();
            }
        }
    }
}