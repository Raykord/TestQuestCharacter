using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoading : MonoBehaviour
{
    
    [SerializeField] private Slider _progressBar;

    

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("sceneName"))
        {
            StartCoroutine(LoadScene(PlayerPrefs.GetString("sceneName")));
        }
        else
        {
            StartCoroutine(LoadScene("Menu"));
        }
    }

    private IEnumerator LoadScene(string sceneName)
    {
        Debug.Log("Loading...");
        AsyncOperation loadConcreteSceen = SceneManager.LoadSceneAsync(sceneName);
        loadConcreteSceen.allowSceneActivation = false;

        while (!loadConcreteSceen.isDone)
        {
            _progressBar.value = loadConcreteSceen.progress;

            if (loadConcreteSceen.progress == 0.9f) loadConcreteSceen.allowSceneActivation = true;

            yield return null;
        }


    }
}
