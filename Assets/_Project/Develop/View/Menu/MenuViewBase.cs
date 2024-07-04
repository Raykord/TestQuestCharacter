using UnityEngine;

public abstract class MenuViewBase : MonoBehaviour
{
    public abstract void ShowCharacter(int indexOfCharacter);

    public abstract void HideCharacter(int indexOfCharacter);

    public abstract void ShowStats(CharacterParameters stats);
}
