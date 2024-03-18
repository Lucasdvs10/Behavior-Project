using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.BehaviorTree {
    public class MoveTowardsPlayerTask : Node {
        HorizontalMovements _horizontalMovements;
        Vector3 _playerPosition;
        
        public MoveTowardsPlayerTask(List<Node> childrenList, HorizontalMovements horizontalMovements, Vector3 playerPosition) : base(childrenList) {
            _horizontalMovements = horizontalMovements;
            _playerPosition = playerPosition;
        }
        
        private void MoveTowardsPlayer() {
            if (_playerPosition.x > _horizontalMovements.transform.position.x) {
                _horizontalMovements.MoveRight();
            } else {
                _horizontalMovements.MoveLeft();
            }
        }

        public override ENodeStatus Evaluate() {
            _nodeStatus = ENodeStatus.RUNNING;
            MoveTowardsPlayer();
            
            return _nodeStatus;
        }
    }
}