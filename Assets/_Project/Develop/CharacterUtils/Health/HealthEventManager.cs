using System;
using UnityEngine;

public class HealthEventManager : MonoBehaviour
{
    public static event Action<int> OnHealthChanged;
    public static event Action OnHealthEqualZero;

    public static void SendHealthChanged(int health)
    {
        OnHealthChanged?.Invoke(health);
    }

    public static void SendHealthEqualZero()
    {
        OnHealthEqualZero?.Invoke();
    }
}
