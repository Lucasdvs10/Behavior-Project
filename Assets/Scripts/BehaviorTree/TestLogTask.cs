using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.BehaviorTree {
    public class TestLogTask : Node {
        bool _returnSucessFlag;
        
        public TestLogTask(List<Node> childrenList, bool returnSucessFlag=true) : base(childrenList) {
            _returnSucessFlag = returnSucessFlag;
        }

        public override ENodeStatus Evaluate() {
            Debug.Log("Log de teste");
            _nodeStatus = _returnSucessFlag ? ENodeStatus.SUCCESS : ENodeStatus.FAILED;
            return _nodeStatus;
        }
    }
}