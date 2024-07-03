using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] protected MenuView _view;
    [SerializeField] private ScriptableModel _model;
    private int selectedCharacter = 0;
    private void Start()
    {
        _view.ShowCharacter(selectedCharacter);
        _view.ShowStats(_model.GetCharacter(selectedCharacter));
    }

    public void NextCharacter()
    {
        _view.HideCharacter(selectedCharacter);
        selectedCharacter++;
        if (selectedCharacter >= _model.CharactersCount)
        {
            selectedCharacter = 0;
        }
        _view.ShowCharacter(selectedCharacter);
        _view.ShowStats(_model.GetCharacter(selectedCharacter));
    }

    public void PrevCharacter()
    {
        _view.HideCharacter(selectedCharacter);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter = _model.CharactersCount - 1;
        }
        _view.ShowCharacter(selectedCharacter);
        _view.ShowStats(_model.GetCharacter(selectedCharacter));
    }

    public void SelectCharacter()
    {
        _model.SetSelectedCharacter(selectedCharacter);
    }
}
