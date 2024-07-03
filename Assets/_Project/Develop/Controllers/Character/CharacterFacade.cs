using UnityEngine;

public abstract class CharacterFacade : MonoBehaviour 
{
    protected IControlable _characterMovement;
    protected CharacterInputController _characterInput;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float rotateSpeed;
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
