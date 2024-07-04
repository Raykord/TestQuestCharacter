using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class GameplayEntryPoint : MonoBehaviour
{
    [SerializeField] ScriptableModel gameModel;
    
    private GameObject _player;


    IEnumerator Start()
    {
        var path = gameModel.GetCharacter(gameModel.SelectedCharacter).Name;
        Debug.Log(path);
        var prefab = path;
        var hande = Addressables.LoadAssetAsync<GameObject>(prefab);
        yield return hande;
        _player = hande.Result;
        _player.SetActive(true);
        Instantiate(_player);
        
    }

    

    private void OnDestroy()
    {
        if (_player != null)
        {
            _player.SetActive(false);
            Addressables.ReleaseInstance(_player);
            _player = null;
        }   
    }
}
