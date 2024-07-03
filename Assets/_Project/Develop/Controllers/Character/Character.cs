using UnityEngine;

public class Character : CharacterFacade
{
    public override void Move()
    {
        var movingDirection = _characterInput.ReadMovement();
        Debug.Log(movingDirection.ToString());
        _characterMovement.Move(movingDirection, gameObject.transform, moveSpeed);
    }

    public override void Rotate()
    {
        _characterMovement.Rotate(_characterInput.RotateDirection, gameObject.transform, rotateSpeed);
    }

}
