using UnityEngine;

public class CharacterLoader : BaseLoader
{
    private string _characterPath;

    public CharacterLoader(string characterPath)
    {
        _characterPath = characterPath;
    }

    public GameObject LoadCharacter()
    {
        LoadAsset(_characterPath);
        return _loadedObject;
    }

    public void UnliadCharacter()
    {
        UnloadAsset();
    }
}
