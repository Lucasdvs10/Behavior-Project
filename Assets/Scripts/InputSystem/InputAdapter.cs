using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace DefaultNamespace.InputSystem {
    public class InputAdapter : MonoBehaviour {
        public UnityEvent DownInputPressed;
        public UnityEvent DownInputReleased;
        public UnityEvent LeftInputPressed;
        public UnityEvent LeftInputReleased;
        public UnityEvent RightInputPressed;
        public UnityEvent RightInputReleased;
        public UnityEvent JumpInputPressed;
        public UnityEvent JumpInputReleased;
        public UnityEvent LeftClickInputPressed;
        public UnityEvent LeftClickInputReleased;
        
        public void UpInput(InputAction.CallbackContext context) {
            if(context.performed) LeftClickInputPressed?.Invoke();
            else if(context.canceled) LeftClickInputReleased?.Invoke();
        }
        
        public void DownInput(InputAction.CallbackContext context) {
            if(context.performed) DownInputPressed?.Invoke();
            else if(context.canceled) DownInputReleased?.Invoke();
        }
        
        public void LeftInput(InputAction.CallbackContext context) {
            if(context.performed) LeftInputPressed?.Invoke();
            else if(context.canceled) LeftInputReleased?.Invoke();
        }
        
        public void RightInput(InputAction.CallbackContext context) {
            if(context.performed) RightInputPressed?.Invoke();
            else if(context.canceled) RightInputReleased?.Invoke();
        }
        
        public void JumpInput(InputAction.CallbackContext context) {
            if(context.performed) JumpInputPressed?.Invoke();
            else if(context.canceled) JumpInputReleased?.Invoke();
        }
        
    }
}