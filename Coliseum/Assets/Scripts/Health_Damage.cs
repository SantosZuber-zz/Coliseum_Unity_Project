using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health_Damage : MonoBehaviour
{

    public int vida = 100;
    [SerializeField] GameObject Enemy;

    void Update()
    {
        if (vida <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void RestarVida(int cantidad)
    {
        vida -= cantidad;
    }
}
