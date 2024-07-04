using UnityEngine;

public class MenuController : MenuControllerBase
{
    [SerializeField] protected MenuViewBase _view;
    [SerializeField] private ScriptableModel _model;
    private int selectedCharacter = 0;
    private void Start()
    {
        _view.ShowCharacter(selectedCharacter);
        _view.ShowStats(_model.GetCharacter(selectedCharacter));
    }

    public override void NextCharacter()
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

    public override void PrevCharacter()
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

    public override void SelectCharacter()
    {
        _model.SelectedCharacter = selectedCharacter;
    }
}
