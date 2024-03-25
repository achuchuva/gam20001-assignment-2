using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefabToInstantiate; 

    void Start()
    {
        Vector3 spawnPosition = new Vector3(0f, 2f, 0f); 
        Quaternion spawnRotation = Quaternion.identity; 
        GameObject spawnedObject = Instantiate(prefabToInstantiate, spawnPosition, spawnRotation);

        spawnedObject.name = "MySpawnedObject";

        spawnedObject.transform.SetParent(transform); 
    }
}
