using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraInteraction : MonoBehaviour
{
    [SerializeField] private new Transform camera;
    [SerializeField] private float rayDistance;
    [SerializeField] GameManager gameManager;
    private float timer;
    private bool canHit1 = true;

    void Start()
    {

    }

    void Update()
    {
        Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.green);

        if (Input.GetButtonDown("Attack"))
        {
            RaycastHit hit;
            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Enemy")) && (canHit1 == true && gameManager.pause == false))
            {
                hit.transform.GetComponent<Raycasted>().Interact();
            }
            canHit1 = false;
        }
        if (!canHit1)
        {
            timer = timer + 1f * Time.deltaTime;
            if (timer >= 0.2f)
            {
                canHit1 = true;
                timer = 0f;
            }
        }
    }
}
