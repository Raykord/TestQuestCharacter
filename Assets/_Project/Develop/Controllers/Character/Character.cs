using UnityEngine;

public class Character : CharacterFacade
{
    private GameObject _gameObject;

    public Character(Rigidbody rigidbody, CharacterParameters parameters, GameObject gameObject) : base(rigidbody, parameters)
    {
        _gameObject = gameObject;
    }

    public override void Move()
    {
        var movingDirection = _characterInput.ReadMovement();
        _characterMovement.Move(movingDirection, _gameObject.transform, _characterParameters.Speed);
    }

    public override void Rotate()
    {
        _characterMovement.Rotate(_characterInput.RotateDirection, _gameObject.transform, _characterParameters.RotateSpeed);
    }


    
}
