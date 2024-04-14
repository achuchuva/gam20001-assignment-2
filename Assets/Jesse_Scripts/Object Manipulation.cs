using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectManipulator : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    private GameObject spawnedObject;
    private InputActionMap objectManipulationMap;

    void Start()
    {
        objectManipulationMap = GetComponent<PlayerInput>().actions.FindActionMap("ObjectManipulation");
        objectManipulationMap.Enable();

        objectManipulationMap["HideObject"].performed += ctx => ToggleObjectVisibility();
        objectManipulationMap["CreateObject"].performed += ctx => SpawnObject();
        objectManipulationMap["DeleteObject"].performed += ctx => DestroyObject();

        SpawnObject();
    }

    void Update()
    {
        HandleInputs();
    }

    void SpawnObject()
    {
        Vector3 spawnPosition = new Vector3(0f, 2f, 0f);
        Quaternion spawnRotation = Quaternion.identity;
        spawnedObject = Instantiate(prefabToInstantiate, spawnPosition, spawnRotation);

        spawnedObject.name = "MySpawnedObject";
        spawnedObject.transform.SetParent(transform);
    }

    void HandleInputs()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            ToggleObjectVisibility();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SpawnObject();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            DestroyObject();
        }
    }

    void ToggleObjectVisibility()
    {
        spawnedObject.SetActive(!spawnedObject.activeSelf);
    }

    void DestroyObject()
    {
        Destroy(spawnedObject);
    }
}
