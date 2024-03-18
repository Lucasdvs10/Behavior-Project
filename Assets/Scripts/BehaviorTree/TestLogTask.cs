using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.BehaviorTree {
    public class TestLogTask : Node {
        public TestLogTask(Node parent, List<Node> childrenList) : base(parent, childrenList) {
        }

        public override ENodeStatus Evaluate() {
            Debug.Log("Log de teste");
            _nodeStatus = ENodeStatus.SUCCESS;
            return _nodeStatus;
        }
    }
}