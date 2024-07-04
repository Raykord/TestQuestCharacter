using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInputWASD : CharacterInputControllerBase
{
    public override Vector3 ReadMovement()
    {
        Vector3 moveDirection = _input.Gameplay.MovementWASD.ReadValue<Vector3>();
        return moveDirection;
    }

    protected override void OnMouseMovinngPerform(InputAction.CallbackContext context)
    {
        RotateDirection = context.ReadValue<Vector2>();
    }
}
