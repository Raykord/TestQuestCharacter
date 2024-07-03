using UnityEngine;

public abstract class CharacterFacade : MonoBehaviour 
{
    protected IControlable _characterMovement;
    protected CharacterInputController _characterInput;


    protected void Awake()
    {
        _characterMovement = new CharacterMovementController(gameObject.GetComponent<Rigidbody>());
        _characterInput = new CharacterInputController();
    }

    protected virtual void OnEnable()
    {
        _characterInput.SubscribeMovingMethods();
    }


    protected virtual void OnDisable()
    {
        _characterInput.UnsubscribeMovingMethods();
    }

    

    protected abstract void Move();

    protected abstract void Rotate();
   
}
