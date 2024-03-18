using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.BehaviorTree {
    public class CheckPlayerIsNearbyNode : Node {
        private Transform _playerTransform;
        private Transform _thisTransform;
        
        public CheckPlayerIsNearbyNode(List<Node> childrenList, Transform playerTransform, Transform thisTransform) : base(childrenList) {
            _playerTransform = playerTransform;
            _thisTransform = thisTransform;
        }

        public override ENodeStatus Evaluate() {
            if (Vector3.SqrMagnitude(_playerTransform.position - _thisTransform.position) < 25) {
                _nodeStatus = ENodeStatus.SUCCESS;
            } else {
                _nodeStatus = ENodeStatus.FAILED;
            }
            return _nodeStatus;
        }
    }
}