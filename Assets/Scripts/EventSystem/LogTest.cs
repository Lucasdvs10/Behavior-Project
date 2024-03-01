using UnityEngine;

namespace Scripts.EventSystem {
    public class LogTest : MonoBehaviour {
        public void TestLog() {
            Debug.Log("LogTestFunction", this);
        }
    }
}