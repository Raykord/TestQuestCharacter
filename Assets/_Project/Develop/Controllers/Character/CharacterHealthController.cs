using UnityEngine;

public class CharacterHealthController : Health
{
    public override void SetMaxHealth(CharacterParameters parameters)
    {
        _maxHealth = parameters.MaxHealth;
        _health = _maxHealth;
        HealthEventManager.SendHealthChanged(PlayerHealth);
    }

    public override void IncreaseHealth(int count)
    {
        _health += count;
        if (_health > _maxHealth) _health = _maxHealth;
        Debug.Log(_health.ToString());
        HealthEventManager.SendHealthChanged(PlayerHealth);
    }

    public override void DecreaseHealth(int count)
    {
        _health -= count;
        if (_health <= 0)
        {
            _health = 0;
            HealthEventManager.SendHealthEqualZero();
        }
        Debug.Log(_health.ToString());
        HealthEventManager.SendHealthChanged(PlayerHealth);
    }
}
