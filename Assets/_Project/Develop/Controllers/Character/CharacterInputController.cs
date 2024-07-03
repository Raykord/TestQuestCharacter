using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInputController
{
    private GameControlls _input;


    public Vector2 RotateDirection { get; private set; }

    public CharacterInputController()
    {
        _input = new GameControlls();
        _input.Menu.Disable();
        _input.Gameplay.Enable();
        
    }

    public void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void SubscribeMovingMethods()
    {
        _input.Gameplay.CameraRotating.performed += OnMouseMovinngPerform;
    }

    public void UnsubscribeMovingMethods()
    {
        _input.Gameplay.CameraRotating.performed -= OnMouseMovinngPerform;
    }

    


    public Vector3 ReadMovement()
    {
        Vector3 moveDirection = _input.Gameplay.Movement.ReadValue<Vector3>();
        return moveDirection;
    }

    private void OnMouseMovinngPerform(InputAction.CallbackContext context)
    {
        RotateDirection = context.ReadValue<Vector2>();
    }
}
