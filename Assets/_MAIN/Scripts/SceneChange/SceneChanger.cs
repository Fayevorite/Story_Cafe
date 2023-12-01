using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        SceneChanger sceneLoader = GetComponent<SceneChanger>();
        sceneLoader.LoadScene("Scene1");
    }
    
}
