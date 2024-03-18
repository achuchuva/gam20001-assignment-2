using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Detector : MonoBehaviour
{
    [SerializeField]
    private GameObject collisionSpawnedObject;
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("This object " + transform.name + " collided with object " + other.transform.name);
        Instantiate(collisionSpawnedObject, other.contacts[0].point, Quaternion.identity);
        audio.Play();
    }
}
