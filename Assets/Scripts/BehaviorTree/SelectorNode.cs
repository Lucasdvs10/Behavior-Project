using System.Collections.Generic;

namespace DefaultNamespace.BehaviorTree {
    public class SelectorNode : Node{
        public SelectorNode(List<Node> childrenList) : base(childrenList) {
        }

        public override ENodeStatus Evaluate() {
            foreach (var child in _childrenList) {
                var status = child.Evaluate();
                if (status != ENodeStatus.FAILED) {
                    _nodeStatus = status;
                    return status;
                }
            }
            _nodeStatus = ENodeStatus.FAILED;
            return _nodeStatus;
        }
    }
}