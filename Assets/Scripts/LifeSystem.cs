using Scripts.EventSystem;
using UnityEngine;

namespace DefaultNamespace {
    public class LifeSystem : MonoBehaviour {
        [SerializeField] private int _maxLife;
        [SerializeField] SOBaseGlobalEvent _onDeathEvent;
        [SerializeField] SOBaseGlobalEvent _onDamageEvent;
        int _currentLife;
        
        private void Awake() {
            _currentLife = _maxLife;
        }

        [ContextMenu("TestDamage")]
        public void TestDamage() {
            TakeDamage(1);
        }
        
        public void TakeDamage(int damage) {
            _currentLife -= damage;
            if (_currentLife > 0) {
                _onDamageEvent.InvokeEvent();
            }
            else{
                _onDeathEvent.InvokeEvent();
            }
        }
    }
}