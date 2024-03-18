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
            if(_returnSucessFlag)
                _nodeStatus = ENodeStatus.SUCCESS;
            else
                _nodeStatus = ENodeStatus.FAILED;
            return _nodeStatus;
        }
    }
}