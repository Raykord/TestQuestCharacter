using UnityEngine;
using UnityEngine.InputSystem;

public abstract class CharacterInputControllerBase
{
    protected GameControlls _input;

    public CharacterInputControllerBase()
    {
        _input = new GameControlls();
        _input.Menu.Disable();
        _input.Gameplay.Enable();

    }

    public Vector2 RotateDirection { get; protected set; }

    public abstract Vector3 ReadMovement();

    public void SubscribeMovingMethods()
    {
        _input.Gameplay.CameraRotating.performed += OnMouseMovinngPerform;
    }

    public void UnsubscribeMovingMethods()
    {
        _input.Gameplay.CameraRotating.performed -= OnMouseMovinngPerform;
    }

    protected abstract void OnMouseMovinngPerform(InputAction.CallbackContext context);
}