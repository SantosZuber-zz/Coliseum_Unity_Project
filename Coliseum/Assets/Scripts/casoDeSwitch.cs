using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class casoDeSwitch : MonoBehaviour
{
    //remplace el 0 por el caso que quiera
    private int caso = 0;



    void Start()
    {
        switch (caso)
        {
            case 0:
            Debug.Log("Ha seleccionado caso 0");
            break;
            case 1:
            Debug.Log("Ha seleccionado caso 1");
            break;
            case 2:
            Debug.Log("Ha seleccionado caso 2");
            break;
            default:
            Debug.Log("Probablemente selecciono mal el caso");
            break;
        }
    }
}
