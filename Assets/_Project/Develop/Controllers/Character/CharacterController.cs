using UnityEngine;

public class CharacterController : MonoBehaviour
{ 
    private CharacterFacade _character;

    [SerializeField]private CharacterParameters parameters;


    protected void Awake()
    {
        _character = new Character(GetComponent<Rigidbody>(), parameters, gameObject, GetComponent<Health>());
        _character = new CharacterInputFromArrowsToWASD(GetComponent<Rigidbody>(), parameters, gameObject, _character, GetComponent<Health>());
    }

    private void OnEnable()
    {
        _character.SubMethods();
    }

    private void OnDisable()
    {
        _character.UnsubMethods();
    }

    protected void Update()
    {
        _character.Rotate();

    }

    protected void FixedUpdate()
    {
        var direction = _character.CalculateDirecrion();
        _character.Move(direction);
    }

    public void IncreaseHealth(int count)
    {
        _character.IncreaseHealth(count);
    }

    public void DecreaseHealth(int count)
    {
        _character.DecreaseHealth(count);
    }
}
