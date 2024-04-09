using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Selector : MonoBehaviour
{
    public GameObject[] objectsToCycle;
    private int currentIndex = 0;

    void Start()
    {
        ActivateObject(currentIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DeactivateObject(currentIndex);

            currentIndex = (currentIndex + 1) % objectsToCycle.Length;

            ActivateObject(currentIndex);
        }
    }

    void ActivateObject(int index)
    {
        if (index >= 0 && index < objectsToCycle.Length)
        {
            objectsToCycle[index].SetActive(true);
        }
    }

    void DeactivateObject(int index)
    {
        if (index >= 0 && index < objectsToCycle.Length)
        {
            objectsToCycle[index].SetActive(false);
        }
    }
}
