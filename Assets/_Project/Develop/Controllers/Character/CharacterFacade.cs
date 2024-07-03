using UnityEngine;

public abstract class CharacterFacade 
{
    protected MoveController _characterMovement;
    protected CharacterInputControllerBase _characterInput;
    protected CharacterParameters _characterParameters;
    protected bool _cursorIsToggled;
    

    public CharacterFacade(Rigidbody rigidbody, CharacterParameters parameters)
    {
        _characterMovement = new CharacterMovementController(rigidbody);
        _characterInput = new CharacterInputController();
        _characterParameters = parameters;
    }

   

    public virtual void SubMethods()
    {
        _characterInput.SubscribeMovingMethods();
    }


    public virtual void UnsubMethods()
    {
        _characterInput.UnsubscribeMovingMethods();
    }




    public abstract void Move();

    public abstract void Rotate();
   
}
