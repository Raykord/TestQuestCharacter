using UnityEngine;
using UnityEngine.InputSystem;

public class GameplayViewController : GameplayViewControllerBase
{
    [SerializeField] GameObject canIteractText;

    protected override void GetMouseControll(InputAction.CallbackContext context)
    {
        _view.ToggleCursor();
    }


    

    private void Start()
    {
        _view.ToggleCursor();
    }

    private void OnEnable()
    {
        _input.Gameplay.ESC.performed += GetMouseControll;
        IteractIventManager.CanIteract += ShowCanIteractText;
        IteractIventManager.CanNotIteract += HideCanIteractText;
    }

    private void OnDisable()
    {
        _input.Gameplay.ESC.performed -= GetMouseControll;
        IteractIventManager.CanIteract -= ShowCanIteractText;
        IteractIventManager.CanNotIteract -= HideCanIteractText;
    }


    private void ShowCanIteractText()
    {
        _view.ShowObject(canIteractText);
    }

    private void HideCanIteractText()
    {
        _view.HideObject(canIteractText);
    }

}
