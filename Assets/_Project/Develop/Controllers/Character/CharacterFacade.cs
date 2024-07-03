using UnityEngine;

public abstract class CharacterFacade : MonoBehaviour 
{
    protected MoveController _characterMovement;
    protected CharacterInputControllerBase _characterInput;
    [SerializeField] protected CharacterParameters characterParameters;
    protected bool _cursorIsToggled;

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




    public abstract void Move();

    public abstract void Rotate();
   
}
