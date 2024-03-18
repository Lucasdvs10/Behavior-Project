using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.BehaviorTree {
    public class BehaviorTreeMono : MonoBehaviour {
        private Node _root;
        Transform _playerTransform;

        private void Awake() {
            _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
            
            _root = new SelectorNode(new List<Node>() {
                    
                        new SequenceNode( new List<Node>(){
                                    new CheckPlayerIsNearbyNode(_playerTransform, transform),
                                    new StopMovingTowardsPlayerTask(GetComponent<HorizontalMovements>())
                                }
                            ),
                        new SequenceNode(new List<Node>() {
                                    new MoveTowardsPlayerTask(GetComponent<HorizontalMovements>(),_playerTransform)
                            }
                            )
                    }
                );
        }

        private void Start() {
            EvaluateRoot();
        }

        [ContextMenu("Evaluate Root")]
        public void EvaluateRoot() {
            _root.Evaluate();
        }
    }
}