using System.Collections.Generic;
using UnityEngine;

public class MenuView : MenuViewBase
{
    [SerializeField] private List<GameObject> charactersOnScene;
    [SerializeField] private TMPro.TextMeshProUGUI statsText;


    public override void ShowCharacter(int indexOfCharacter)
    {
        charactersOnScene[indexOfCharacter].SetActive(true);
    }


    public override void HideCharacter(int indexOfCharacter)
    {
        charactersOnScene[indexOfCharacter].SetActive(false);
    }

    public override void ShowStats(CharacterParameters stats)
    {
        statsText.text = $"Name: {stats.Name}\nSpeed: {stats.Speed}\nHealth: {stats.MaxHealth}";
    }

}
