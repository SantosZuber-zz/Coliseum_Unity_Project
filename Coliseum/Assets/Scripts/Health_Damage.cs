using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Health_Damage : MonoBehaviour
{

    public int vida = 100;
    [SerializeField] GameObject Enemy;
    PlayerEvent player = new PlayerEvent();

    void Start()
    {
        player.onDeath += GameOverBehavior;
    }
    void Update()
    {
        if (vida <= 0)
        {
            player.OnDeath();
        }
    }
    public void RestarVida(int cantidad)
    {
        vida -= cantidad;
    }
    void GameOverBehavior(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Evento onDeath, llamado por Health_Damage");
    }
}
