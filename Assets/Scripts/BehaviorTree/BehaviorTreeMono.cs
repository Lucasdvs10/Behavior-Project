using UnityEngine;

namespace DefaultNamespace.BehaviorTree {
    public class BehaviorTreeMono : MonoBehaviour {
        private Node _root;

        private void Awake() {
            _root = new TestLogTask(null, null);
        }

        [ContextMenu("Evaluate Root")]
        public void EvaluateRoot() {
            _root.Evaluate();
        }
    }
}