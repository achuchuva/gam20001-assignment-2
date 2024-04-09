using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Changer : MonoBehaviour
{
    public string[] sceneNames;
    private int currentSceneIndex = 0;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentSceneIndex = (currentSceneIndex + 1) % sceneNames.Length;
            LoadScene(currentSceneIndex);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentSceneIndex = (currentSceneIndex - 1 + sceneNames.Length) % sceneNames.Length;
            LoadScene(currentSceneIndex);
        }
    }

    void LoadScene(int index)
    {
        if (index >= 0 && index < sceneNames.Length)
        {
            SceneManager.LoadScene(sceneNames[index]);
        }
    }
}
