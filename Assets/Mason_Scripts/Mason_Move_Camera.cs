using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mason_Move_Camera : MonoBehaviour
{
    public Transform CameraPosition;

    private void Update()
    {
        transform.position = CameraPosition.position;
    }
}
