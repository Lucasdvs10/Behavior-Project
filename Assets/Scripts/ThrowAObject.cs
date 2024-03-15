using UnityEngine;

namespace DefaultNamespace {
    public class ThrowAObject : MonoBehaviour {
        [SerializeField] GameObject _objectToThrow;

        [ContextMenu("ThrowObject")]
        public void ThrowObjectToRight() {
            ThrowObject(1);
        }
        
        public void ThrowObject(int direction) {
            var objectToThrow = Instantiate(_objectToThrow, transform.position+new Vector3(0, 0.5f, 0), Quaternion.identity);
            var horizontalMovements = objectToThrow.GetComponent<HorizontalMovements>();

            if (horizontalMovements == null) {
                objectToThrow.AddComponent<HorizontalMovements>();
            }
            
            horizontalMovements.Move(direction);
        }
    }
}