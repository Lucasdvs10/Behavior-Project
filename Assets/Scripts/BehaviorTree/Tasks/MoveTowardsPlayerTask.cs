using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.BehaviorTree {
    public class MoveTowardsPlayerTask : Node {
        HorizontalMovements _horizontalMovements;
        Transform _playerTransform;
        
        public MoveTowardsPlayerTask(List<Node> childrenList, HorizontalMovements horizontalMovements, Transform playerTransform) : base(childrenList) {
            _horizontalMovements = horizontalMovements;
            _playerTransform = playerTransform;
        }
        
        private void MoveTowardsPlayer() {
            if (_playerTransform.position.x > _horizontalMovements.transform.position.x) {
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