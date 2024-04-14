using UnityEngine;

public class UpDown : MonoBehaviour
{
    public float moveSpeed = 2.0f; 
    public float moveDistance = 1.0f; 

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float verticalMovement = Mathf.Sin(Time.time * moveSpeed) * moveDistance;

        transform.position = startPosition + Vector3.up * verticalMovement;
    }
}
