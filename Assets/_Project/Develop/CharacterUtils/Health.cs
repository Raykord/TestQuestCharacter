using UnityEngine;

public abstract class Health : MonoBehaviour 
{
    protected int health;
    protected int maxHealth;

    public abstract void SetMaxHealth(CharacterParameters parameters);

    public abstract void IncreaseHealth(int count);


    public abstract void DecreaseHealth(int count);
    
}
