using UnityEngine;

public abstract class MenuControllerBase : MonoBehaviour
{
    public abstract void NextCharacter();
    public abstract void PrevCharacter();
    public abstract void SelectCharacter();
}