using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropmain : MonoBehaviour
{
    [SerializeField] private GameObject[] armas;
    private float timer;
    private bool canSpawn = false;
    void Start()
    {

    }

    void Update()
    {
        if (canSpawn == false)
        {
            timer = timer + 1f * Time.deltaTime;
            if (timer >= 10f)
            {
                canSpawn = true;
                timer = 0f;
            }
        }
        if (canSpawn)
        {
            SpawnearArma();
            canSpawn = false;
        }
    }
    void SpawnearArma()
    {
        int armasIndex = Random.Range(0, armas.Length);
        Instantiate(armas[armasIndex], transform);
    }
}
