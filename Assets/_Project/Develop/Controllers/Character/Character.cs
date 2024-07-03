using UnityEngine;

public class Character : CharacterFacade
{
    protected override void Move()
    {
        var movingDirection = _characterInput.ReadMovement();
        Debug.Log(movingDirection.ToString());
        _characterMovement.Move(movingDirection, gameObject.transform);
    }

    protected override void Rotate()
    {
        _characterMovement.Rotate(_characterInput.RotateDirection, gameObject.transform);
    }

   

    // Update is called once per frame
    void Update()
    {
        
        Rotate();
    }

    private void FixedUpdate()
    {
        Move();
    }
}
