using UnityEngine;

public class PickUpEffect
{
    public void HealEffect(Health health, int count)
    {
        if (health != null)
        {
            health.IncreaseHealth(count);
        }
    }

    public void DamageEffect(Health health, int count)
    {
        if (health != null)
        {
            health.DecreaseHealth(count);
        }
    }
}
