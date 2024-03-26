using UnityEngine;
using UnityEngine.InputSystem;


public class TestInput : MonoBehaviour
{
    private InputAction testAction;
    private PlayerInput playerInput;

    private void Awake()
    {
        //playerInput = GameObject.GetComponent<PlayerInput>()

        testAction = playerInput.actions.FindAction("Jump");
        testAction.performed += DoJumpAction;
    }

    private void OnEnable()
    {
        testAction.Enable();
    }

    private void OnDisable()
    {
        testAction.Disable();
    }

    void DoJumpAction(InputAction.CallbackContext context)
    {
        Debug.Log("JumpAction Success!!");
    }
}