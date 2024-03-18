using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.BehaviorTree {
    public class BehaviorTreeMono : MonoBehaviour {
        private Node _root;

        private void Awake() {
            _root = new SelectorNode(
                new List<Node>(){new TestLogTask(null, false), new TestLogTask(null, false), new TestLogTask(null)}
                );
        }

        private void Start() {
            EvaluateRoot();
        }

        [ContextMenu("Evaluate Root")]
        public void EvaluateRoot() {
            _root.Evaluate();
        }
    }
}