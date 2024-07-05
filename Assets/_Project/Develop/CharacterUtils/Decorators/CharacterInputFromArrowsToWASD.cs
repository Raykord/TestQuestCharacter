using UnityEngine;

public class CharacterInputFromArrowsToWASD : CharacterInputDecorator
{
    GameObject _gameObject;

    public CharacterInputFromArrowsToWASD(Rigidbody rigidbody, CharacterParameters parameters, GameObject gameObject, CharacterFacade character, Health health) : base(rigidbody, parameters, character, health)
    {
        _characterInput = new CharacterInputWASD();
        _gameObject = gameObject;
    }


    public override void Move(Vector3 movingDirection)
    {
        _character.Move(movingDirection);
    }

    public override void Rotate()
    {
        _characterMovement.Rotate(_characterInput.RotateDirection, _gameObject.transform, _characterParameters.RotateSpeed);
    }
}
