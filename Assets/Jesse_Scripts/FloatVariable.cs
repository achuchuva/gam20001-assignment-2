using UnityEngine;

public class SelfDestructor : MonoBehaviour
{
    public float destroyDelay = 3f;

    private float countdownTimer;

    void Start()
    {
        countdownTimer = destroyDelay;
    }

    void Update()
    {
        countdownTimer -= Time.deltaTime;
        if (countdownTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
