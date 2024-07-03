using UnityEngine;

public abstract class MoveController 
{
    public abstract void Move(Vector3 direction, Transform transform, float moveSpeed);
    public abstract void Rotate(Vector2 axis, Transform transform, float rotateSpeed);
}
