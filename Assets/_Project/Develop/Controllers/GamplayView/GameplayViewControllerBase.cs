using UnityEngine;
using UnityEngine.InputSystem;

public abstract class GameplayViewControllerBase : MonoBehaviour
{
    protected GameControlls _input;
    protected GameplayViewBase _view;

    protected virtual void Awake()
    {
        _input = new GameControlls();
        _input.Gameplay.Enable();
        _view = new GameplayView();
    }

    protected abstract void GetMouseControll(InputAction.CallbackContext context);
}
