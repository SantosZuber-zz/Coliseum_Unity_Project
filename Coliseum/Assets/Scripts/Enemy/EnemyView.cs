using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    [SerializeField] Transform seePoint;
    [SerializeField] private float distanceRay;
    [SerializeField] private Animator Animat;
    private int hitCooldown;
    private float timer;
    private bool canHit2 = true;

    void Start()
    {
        Animat.SetBool("isPunching", false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(seePoint.position, seePoint.forward * distanceRay, Color.red);
        emitirRaycast();
        if (!canHit2)
        {
            gameObject.GetComponent<Enemy1>().Attack(false);
            timer = timer + 1f * Time.deltaTime;
            if (timer >= 2f)
            {
                Animat.SetBool("isPunching", false);
                canHit2 = true;
                timer = 0f;
            }
        }
    }
    private void emitirRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(seePoint.position, seePoint.TransformDirection(Vector3.forward), out hit, distanceRay, LayerMask.GetMask("Player")) && canHit2 == true)
        {
            Animat.SetBool("isPunching", true);
            gameObject.GetComponent<Enemy1>().Attack(true);
        }
        canHit2 = false;
    }
}
