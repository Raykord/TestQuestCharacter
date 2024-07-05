using UnityEngine;

public abstract class CharacterFacade 
{
    protected MoveController _characterMovement;
    protected CharacterInputControllerBase _characterInput;
    protected CharacterParameters _characterParameters;
    protected Health _healthSystem;
    protected bool _cursorIsToggled;


    public CharacterFacade(Rigidbody rigidbody, CharacterParameters parameters, Health health)
    {
        _characterMovement = new CharacterMovementController(rigidbody);
        _characterInput = new CharacterInputController();
        _characterParameters = parameters;
        _healthSystem = health;
        _healthSystem.SetMaxHealth(_characterParameters);
    }



    public virtual void SubMethods()
    {
        _characterInput.SubscribeMovingMethods();
    }


    public virtual void UnsubMethods()
    {
        _characterInput.UnsubscribeMovingMethods();
    }

    public virtual Vector3 CalculateDirecrion()
    {
        Vector3 movingDirection = _characterInput.ReadMovement();
        return movingDirection;
    }



    public abstract void Move(Vector3 movingDirection);
    

    public abstract void Rotate();
   
}
