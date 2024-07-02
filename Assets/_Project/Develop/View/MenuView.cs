using System.Collections.Generic;
using UnityEngine;

public class MenuView : MonoBehaviour
{
    [SerializeField] private List<GameObject> charactersOnScene;

   

    public void ShowCharacter(int indexOfCharacter)
    {
        charactersOnScene[indexOfCharacter].SetActive(true);
    }


    public void HideCharacter(int indexOfCharacter)
    {
        charactersOnScene[indexOfCharacter].SetActive(false);
    }

}
