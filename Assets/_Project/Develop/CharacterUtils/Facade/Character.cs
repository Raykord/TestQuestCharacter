using UnityEngine;

public class Character : CharacterFacade
{
    private GameObject _gameObject;

    public Character(Rigidbody rigidbody, CharacterParameters parameters, GameObject gameObject) : base(rigidbody, parameters)
    {
        _gameObject = gameObject;
    }

    //public Character(Rigidbody rigidbody, CharacterParameters parameters, GameObject gameObject) 
    //{
    //    _characterMovement = new CharacterMovementController(rigidbody);
    //    _characterInput = new CharacterInputController();
    //    _characterParameters = parameters;
    //    _gameObject = gameObject;
    //}

    public override void Move(Vector3 movingDirection)
    {
        Debug.Log(movingDirection.ToString());
        _characterMovement.Move(movingDirection, _gameObject.transform, _characterParameters.Speed);
    }

    public override void Rotate()
    {
        _characterMovement.Rotate(_characterInput.RotateDirection, _gameObject.transform, _characterParameters.RotateSpeed);
    }


    
}
