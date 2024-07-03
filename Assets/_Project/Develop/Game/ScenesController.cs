using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesController : MonoBehaviour
{
    public void CallLoadScene(string sceneName)
    {
        PlayerPrefs.SetString("sceneName", sceneName);
        SceneManager.LoadSceneAsync(sceneName);
    }

    
}
