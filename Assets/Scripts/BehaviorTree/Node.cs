using System.Collections.Generic;

namespace DefaultNamespace.BehaviorTree {
    public abstract class Node {
        protected List<Node> _childrenList;
        protected ENodeStatus _nodeStatus;
        public abstract ENodeStatus Evaluate();

        public void AddChild(Node child) {
            _childrenList.Add(child);
        }
        
        public void RemoveChild(Node child) {
            _childrenList.Remove(child);
        }

        public Node(List<Node> childrenList) {
            _childrenList = childrenList;
            _nodeStatus = ENodeStatus.INACTIVE;
        }
        
        public List<Node> ChildrenList => _childrenList;

        public ENodeStatus NodeStatus => _nodeStatus;
    }
}