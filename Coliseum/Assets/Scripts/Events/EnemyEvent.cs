using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyEvent : MonoBehaviour
{
    public event Action onDeath;

    public void OnDeath()
    {
        onDeath?.Invoke();
    }
}
