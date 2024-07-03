using UnityEngine;

public class CharacterController : MonoBehaviour
{ 
    private Character _character;

    [SerializeField]private CharacterParameters parameters;


    protected void Awake()
    {
        _character = new Character(GetComponent<Rigidbody>(), parameters, gameObject);
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
        _character.Move();
    }
}
