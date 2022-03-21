using System.Diagnostics;
using System.Security.Cryptography;
using System.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingDamage : Raycasted
{
    [SerializeField] private GameObject Enemy;
    public override void Interact()
    {
        base.Interact();
        Enemy.GetComponent<Enemy1>().RestarVida(4);
    }
}
