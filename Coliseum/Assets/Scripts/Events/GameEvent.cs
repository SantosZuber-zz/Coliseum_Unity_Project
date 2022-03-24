using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameEvent : MonoBehaviour
{
    public event Action onDrop;
    

    public void OnDrop()
    {
        onDrop?.Invoke();
    }
}
