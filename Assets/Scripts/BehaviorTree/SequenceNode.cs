using System.Collections.Generic;

namespace DefaultNamespace.BehaviorTree {
    public class SequenceNode : Node{
        public SequenceNode(List<Node> childrenList) : base(childrenList) {
        }

        public override ENodeStatus Evaluate() {
            foreach (var child in _childrenList) {
                var status = child.Evaluate();
                if (status != ENodeStatus.SUCCESS) {
                    _nodeStatus = status;
                    return status;
                }
            }
            _nodeStatus = ENodeStatus.SUCCESS;
            return _nodeStatus;
        }
    }
}