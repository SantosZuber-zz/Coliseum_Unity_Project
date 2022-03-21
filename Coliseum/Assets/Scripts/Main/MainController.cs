using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    public void CargarJuego()
    {
        SceneManager.LoadScene(1);
    }

    public void SalirDelJuego()
    {
        Destroy(gameManager);
        SceneManager.LoadScene(0);
    }
}
