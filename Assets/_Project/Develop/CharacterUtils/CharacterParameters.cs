using UnityEngine;


[CreateAssetMenu(fileName = "CharacterParameters", menuName = "Scriptable/Character", order = 1)]
public class CharacterParameters : ScriptableObject
{
    [SerializeField] private float _speed;
    [SerializeField] private string _name;
    [SerializeField] private GameObject _model;

    public float Speed => _speed;
    public string Name => _name;
    public GameObject Model => _model;
}
