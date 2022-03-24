using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropmain : MonoBehaviour
{
    [SerializeField] private GameObject[] armas;
    private float timer;
    private bool canSpawn = false;
    GameEvent gameEvent = new GameEvent();

    void Start()
    {
        gameEvent.onDrop += SpawnearArma;
    }

    void Update()
    {
        if (canSpawn == false)
        {
            timer = timer + 1f * Time.deltaTime;
            if (timer >= 7f)
            {
                canSpawn = true;
                timer = 0f;
            }
        }
        if (canSpawn)
        {
            gameEvent.OnDrop();
            Debug.Log("Evento onDrop, llamado por Dropmain y lo recibio --DROP ARMAS--");
            canSpawn = false;
        }
    }
    void SpawnearArma()
    {
        int armasIndex = Random.Range(0, armas.Length);
        Instantiate(armas[armasIndex], transform);
    }
}
