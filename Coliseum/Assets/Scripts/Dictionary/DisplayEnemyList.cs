using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayEnemyList : MonoBehaviour
{

    Dictionary<int, string> enemigos = new Dictionary<int, string>();


    void Start()
    {
        enemigos.Add(1, "Human");
        enemigos.Add(2, "Futuristic_Human");
        enemigos.Add(3, "Titan");
    }
}
