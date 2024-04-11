using UnityEngine;
using UnityEngine.InputSystem;


public class Jump : MonoBehaviour
{
    private InputActions inputActions;

    private void OnEnable()
    {
        inputActions = new InputActions();
        inputActions.Enable();

        inputActions.Player.Jump.performed += ctx => PerformJump();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    public float jumpForce = 2f;

    void Start()
    {
        var playerControls = new InputActions();
        playerControls.Enable();


        playerControls.Player.Jump.performed += ctx => PerformJump();
    }

    void PerformJump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

}
