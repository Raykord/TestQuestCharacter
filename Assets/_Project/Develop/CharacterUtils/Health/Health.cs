using UnityEngine;

public abstract class Health : MonoBehaviour 
{
    protected int _health;
    protected int _maxHealth;

    public int PlayerHealth => _health;

    public abstract void SetMaxHealth(CharacterParameters parameters);

    public abstract void IncreaseHealth(int count);


    public abstract void DecreaseHealth(int count);
    
}
