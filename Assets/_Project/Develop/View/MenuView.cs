using System.Collections.Generic;
using UnityEngine;

public class MenuView : MonoBehaviour
{
    [SerializeField] private List<GameObject> charactersOnScene;
    [SerializeField] private TMPro.TextMeshProUGUI statsText;
   

    public void ShowCharacter(int indexOfCharacter)
    {
        charactersOnScene[indexOfCharacter].SetActive(true);
    }


    public void HideCharacter(int indexOfCharacter)
    {
        charactersOnScene[indexOfCharacter].SetActive(false);
    }

    public void ShowStats(CharacterParameters stats)
    {
        statsText.text = $"Name: {stats.Name}\nSpeed: {stats.Speed}";
    }

}
