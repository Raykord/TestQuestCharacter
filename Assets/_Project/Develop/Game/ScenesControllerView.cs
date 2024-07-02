using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScenesControllerView : MonoBehaviour
{
    [SerializeField] private GameObject loadingUI;
    private Slider _progressBar;

    public void ShowLoadingUI()
    {
        var loadingInstance = Instantiate(loadingUI);
        _progressBar = loadingInstance.GetComponentInChildren<Slider>();
    }

    public void SetProgress(float progress)
    {
        _progressBar.value = progress;
    }
    
}
