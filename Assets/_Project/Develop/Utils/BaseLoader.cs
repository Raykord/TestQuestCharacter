using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using static UnityEditor.Experimental.GraphView.GraphView;

public class BaseLoader 
{
    protected GameObject _loadedObject;

    protected async void LoadAsset(string prefab)
    {
        var hande = Addressables.LoadAssetAsync<GameObject>(prefab);
        await hande.Task;
        _loadedObject = hande.Result;
       
    }

    protected void UnloadAsset()
    {
        if (_loadedObject == null)
        {
            return;
        }

        _loadedObject.SetActive(false);
        Addressables.ReleaseInstance(_loadedObject);
        _loadedObject = null;
    }
}
