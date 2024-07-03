using UnityEngine;

public class CharacterController : MonoBehaviour
{ 
    private Character _character;


    protected void Start()
    {
        _character = GetComponent<Character>();
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
