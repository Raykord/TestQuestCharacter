using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Model", menuName = "Scriptable/Model", order = 1)]
public class ScriptableModel : ScriptableObject
{

    [SerializeField] private List<CharacterParameters> _characters;
    private int _selectedCharacter;

    public int SelectedCharacter => _selectedCharacter;


    public int CharactersCount
    {
        get { return _characters.Count; }
    }

    public CharacterParameters GetCharacter(int characterType)
    {
        return _characters[characterType];
    }

    public void SetSelectedCharacter(int characterIndex)
    {
        if (characterIndex < 0 ||  characterIndex >= _characters.Count)
        {
            Debug.Log("Некоректный индекс персонажа");
            _selectedCharacter = 0;
            return;
        }
        _selectedCharacter = characterIndex;
    }
}
