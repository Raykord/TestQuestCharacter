using UnityEngine;

public class CharacterMovementController : IControlable
{
    private Rigidbody _rigidbody;
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float rotateSpeed = 5;

    // Start is called before the first frame update
    public CharacterMovementController(Rigidbody rigidbody)
    {
        _rigidbody = rigidbody;
    }


    public void Move(Vector3 direction, Transform transform)
    {
        Vector3 movingDirection = transform.TransformDirection(direction * moveSpeed * Time.fixedDeltaTime);
        movingDirection = movingDirection.normalized;
        _rigidbody.MovePosition(transform.position + movingDirection);
    }

    public void Rotate(Vector2 axis, Transform transform)
    {
        transform.Rotate(0, axis.x * rotateSpeed * Time.deltaTime, 0);
    }
}
