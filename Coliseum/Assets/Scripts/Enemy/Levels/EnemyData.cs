using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName =  "New Enemy Data", menuName = "Create Enemy Data")]
public class EnemyData : ScriptableObject
{
    public int health;
    public float speed = 1.7f;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
