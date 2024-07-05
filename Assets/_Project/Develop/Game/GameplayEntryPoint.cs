using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class GameplayEntryPoint : MonoBehaviour
{
    [SerializeField] private ScriptableModel gameModel;
    [SerializeField] private List<string> ItemColors;
    [SerializeField] private int ItemsCount;
    [SerializeField] private float ItemsSpawRadius;


    private GameObject _player;


    void Start()
    {
        StartCoroutine(LoadCharacter());
        StartCoroutine(LoadItems());
    }

    IEnumerator LoadCharacter()
    {
        var path = gameModel.GetCharacter(gameModel.SelectedCharacter).Name;
        var handle = Addressables.LoadAssetAsync<GameObject>(path);
        yield return handle;
        _player = handle.Result;
        _player.SetActive(true);
        Instantiate(_player);
        Debug.Log("PLAYER SPAWNED");
    }

    IEnumerator LoadItems()
    {
        

        for (int i = 0; i < ItemsCount; i++)
        {
            StringBuilder path = new StringBuilder("InteractObjectColor");
            int randIndex = Random.Range(0, ItemColors.Count);
            path.Replace("Color", ItemColors[randIndex]);
            var prefab = path.ToString();
            var handle = Addressables.LoadAssetAsync<GameObject>(prefab);
            yield return handle;

            if (handle.Status == AsyncOperationStatus.Failed)
            {
                Debug.Log("Item loading was failed");
            }
            else
            {
                var item = handle.Result;
                Vector3 radnomSpawnPos = new Vector3(Random.Range(-ItemsSpawRadius, ItemsSpawRadius), 1, Random.Range(-ItemsSpawRadius, ItemsSpawRadius));
                Instantiate(item, radnomSpawnPos, Quaternion.identity);
            }
        }
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
