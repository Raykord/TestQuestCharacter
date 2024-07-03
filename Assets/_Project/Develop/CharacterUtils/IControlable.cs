using UnityEngine;

public interface IControlable 
{
    public void Move(Vector3 direction, Transform transform);
    public void Rotate(Vector2 axis, Transform transform);
}
