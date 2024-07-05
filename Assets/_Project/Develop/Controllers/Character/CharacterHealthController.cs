using UnityEngine;

public class CharacterHealthController : Health
{
    public override void SetMaxHealth(CharacterParameters parameters)
    {
        maxHealth = parameters.MaxHealth;
        health = maxHealth;
    }

    public override void IncreaseHealth(int count)
    {
        health += count;
        if (health > maxHealth) maxHealth = health;
        Debug.Log(health.ToString());
    }

    public override void DecreaseHealth(int count)
    {
        health -= count;
        if (health < 0) maxHealth = 0;
        Debug.Log(health.ToString());
    }
}
