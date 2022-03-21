using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected EnemyData EnemyStats;
    [SerializeField] protected GameObject player;
    protected float distance;
    [SerializeField] protected Animator Anim;
    [SerializeField] protected Transform Ground;
    [SerializeField] protected float lookSpeed = 1.7f;
    
    protected bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalcularDistancia(){
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
    }

    public virtual void RestarVida(int cantidad)
    {
        EnemyStats.health -= cantidad;
        UnityEngine.Debug.Log("Enemy hitted");
    }
    public void LookAtPlayer()
    {
        if (alive == true)
        {
            Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, lookSpeed * Time.deltaTime);
        }
    }
    public void MoveToPlayer()
    {
        if (distance > 2f && alive == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, EnemyStats.speed * Time.deltaTime);
        }
    }
    public void Death()
    {
        if (EnemyStats.health <= 0)
        {
            alive = false;
            Anim.SetBool("death", true);
            Destroy(gameObject, 3f);
        }
    }
    public void Attack(bool canornot)
    {
        if (canornot == true)
        {
            player.GetComponent<Health_Damage>().RestarVida(EnemyStats.damage);
        }
    }
}
