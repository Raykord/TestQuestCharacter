using UnityEngine;

public abstract class CharacterInputDecorator : CharacterFacade
{
    protected CharacterFacade _character;

    protected CharacterInputDecorator(Rigidbody rigidbody, CharacterParameters parameters, CharacterFacade character) : base(rigidbody, parameters)
    {
        _character = character;
    }

    public override void Move(Vector3 movingDirection)
    {
        _character.Move(movingDirection);
    }

    public override void Rotate()
    {
        _character.Rotate();
    }

    
}
