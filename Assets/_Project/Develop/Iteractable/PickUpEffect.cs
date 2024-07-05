using UnityEngine;


public class PickUpEffect
{
    private void HealEffect(CharacterController health, int count)
    {
        if (health != null)
        {
            health.IncreaseHealth(count);
        }
    }

    private void DamageEffect(CharacterController health, int count)
    {
        if (health != null)
        {
            health.DecreaseHealth(count);
        }
    }

    public void ApplyEffect(CharacterController player, Material material, int count)
    {
        
        var playerMat = player.gameObject.GetComponent<Renderer>().material;
        if (playerMat.color == material.color)
        {
            HealEffect(player, count);
        }
        else
        {
            DamageEffect(player, count);
        }
    }
}
