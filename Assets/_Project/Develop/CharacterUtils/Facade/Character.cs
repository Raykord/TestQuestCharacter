using UnityEngine;

public class Character : CharacterFacade
{
    private GameObject _gameObject;

    public Character(Rigidbody rigidbody, CharacterParameters parameters, GameObject gameObject, Health health) : base(rigidbody, parameters, health)
    {
        _gameObject = gameObject;
}

    

    public override void Move(Vector3 movingDirection)
    {
        
        _characterMovement.Move(movingDirection, _gameObject.transform, _characterParameters.Speed);
    }

    public override void Rotate()
    {
        _characterMovement.Rotate(_characterInput.RotateDirection, _gameObject.transform, _characterParameters.RotateSpeed);
    }


    
}
