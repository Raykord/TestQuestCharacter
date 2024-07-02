using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesController : MonoBehaviour
{
    [SerializeField] private ScenesControllerView view;
    private string _sceneName;




    void Awake()
    {
        DontDestroyOnLoad(gameObject); 
    }

    public void CallLoadScene(string sceneName)
    {
        _sceneName = sceneName;
        StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene()
    {
        yield return SceneManager.LoadSceneAsync("Loading");

        view.ShowLoadingUI();

        AsyncOperation loadConcreteSceen = SceneManager.LoadSceneAsync(_sceneName);
        loadConcreteSceen.allowSceneActivation = false;

        while (!loadConcreteSceen.isDone)
        {
            view.SetProgress(loadConcreteSceen.progress);
            
            if (loadConcreteSceen.progress == 0.9f) loadConcreteSceen.allowSceneActivation = true;

            yield return null;
        }
        
        
    }
}
