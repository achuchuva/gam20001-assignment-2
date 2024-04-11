using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 5f;

    private InputActions inputActions;
    private Vector2 lastMousePosition;

    void Start()
    {
        inputActions = new InputActions();
        inputActions.Enable();

        lastMousePosition = Mouse.current.position.ReadValue();
    }

    void Update()
    {
        Vector2 currentMousePosition = Mouse.current.position.ReadValue();

        if (currentMousePosition != lastMousePosition)
        {
            float mouseX = currentMousePosition.x - lastMousePosition.x;
            float mouseY = currentMousePosition.y - lastMousePosition.y;
            float rotationX = -mouseY * rotationSpeed * Time.deltaTime;
            float rotationY = mouseX * rotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up, rotationY);
            transform.Rotate(Vector3.right, rotationX);

            lastMousePosition = currentMousePosition;
        }
    }

    void OnDisable()
    {
        inputActions.Disable();
    }
}
