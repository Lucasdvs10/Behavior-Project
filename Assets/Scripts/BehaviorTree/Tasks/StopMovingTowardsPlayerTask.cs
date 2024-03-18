using System.Collections.Generic;

namespace DefaultNamespace.BehaviorTree {
    public class StopMovingTowardsPlayerTask : Node{
        HorizontalMovements _horizontalMovements;
        
        public StopMovingTowardsPlayerTask(List<Node> childrenList, HorizontalMovements horizontalMovements) : base(childrenList) {
            _horizontalMovements = horizontalMovements;
        }

        public override ENodeStatus Evaluate() {
            _horizontalMovements.StopMoving();
            _nodeStatus = ENodeStatus.SUCCESS;
            return _nodeStatus;
        }
    }
}