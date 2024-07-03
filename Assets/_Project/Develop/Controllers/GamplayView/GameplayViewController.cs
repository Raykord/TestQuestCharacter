using UnityEngine;
using UnityEngine.InputSystem;

public class GameplayViewController : GameplayViewControllerBase
{
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
    }

    private void OnDisable()
    {
        _input.Gameplay.ESC.performed -= GetMouseControll;
    }


}
