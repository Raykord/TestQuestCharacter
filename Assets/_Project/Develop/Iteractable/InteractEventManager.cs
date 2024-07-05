using System;
using UnityEngine;

public class InteractEventManager 
{
    public static event Action CanInteract;
    public static event Action CanNotInteract;
    public static event Action OnInteract;

    public static void SendCanInteract()
    {
        
        CanInteract?.Invoke();
        
    }

    public static void SendCanNotInteract()
    {

        CanNotInteract?.Invoke();

    }

    public static void SendInteract()
    {

        OnInteract?.Invoke();

    }
}
