using UnityEngine;

public class RealoadGame : MonoBehaviour 
{
    private ScenesController _scenesController;

    private void Awake()
    {
        _scenesController = GetComponent<ScenesController>();
    }

    private void OnEnable()
    {
        HealthEventManager.OnHealthEqualZero += ReloadGameScene;
    }

    private void OnDisable()
    {
        HealthEventManager.OnHealthEqualZero -= ReloadGameScene;
    }


    void ReloadGameScene()
    {
        _scenesController.CallLoadScene("Game");
    }
}
