using System;
using UnityEngine;

public class IteractIventManager 
{
    public static event Action CanIteract;
    public static event Action CanNotIteract;

    public static void SendCanIteract()
    {
        
        CanIteract?.Invoke();
        
    }

    public static void SendCanNotIteract()
    {

        CanNotIteract?.Invoke();

    }
}
