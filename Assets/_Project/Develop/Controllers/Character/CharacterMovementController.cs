using UnityEngine;

public class CharacterMovementController : MoveController
{
    private Rigidbody _rigidbody;
    //[SerializeField] private float moveSpeed = 1;
    //[SerializeField] private float rotateSpeed = 1;

    // Start is called before the first frame update
    public CharacterMovementController(Rigidbody rigidbody)
    {
        _rigidbody = rigidbody;
    }


    public override void Move(Vector3 direction, Transform transform, float moveSpeed)
    {
        Vector3 movingDirection = transform.TransformDirection(direction.normalized * moveSpeed * Time.fixedDeltaTime);
        _rigidbody.velocity = movingDirection;
    }

    public override void Rotate(Vector2 axis, Transform transform, float rotateSpeed)
    {
        transform.Rotate(0, axis.x * rotateSpeed * Time.deltaTime, 0);
    }
}
