using UnityEngine;


[CreateAssetMenu(fileName = "CharacterParameters", menuName = "Scriptable/Character", order = 1)]
public class CharacterParameters : ScriptableObject
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private string _name;
    [SerializeField] private GameObject _model;
    [SerializeField] private int _maxHealth;

    public float Speed => _speed;
    public float RotateSpeed => _rotateSpeed;
    public string Name => _name;
    public GameObject Model => _model;
    public int MaxHealth => _maxHealth;
}
