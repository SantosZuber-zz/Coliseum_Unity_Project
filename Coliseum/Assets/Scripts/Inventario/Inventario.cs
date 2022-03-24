using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Inventario : MonoBehaviour
{
    [SerializeField] private UnityEvent GrabMace;
    [SerializeField] private UnityEvent GrabAxe;
    [SerializeField] private UnityEvent GrabWand;

    [SerializeField] List<GameObject> Inventory;
    [SerializeField] GameObject[] armas;
    [SerializeField] GameObject[] objetos;
    [SerializeField] GameObject dropPoint;
    private int item_damage;
    private int item_name;
    private int item_description;
    public bool index;
    public bool index1;
    public bool index2;
    public bool mace;
    public bool axe;
    public bool wand;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AnadirMace();
        AnadirAxe();
        AnadirWand();
    }

    void AnadirMace()
    {
        if (mace == true && index == false && (axe == false && wand == false))
        {
            GrabMace?.Invoke();
            Inventory.Add(armas[0]);
            Debug.Log("Mace anadido");
            index = true;
        }
        if (Input.GetKeyDown(KeyCode.Q) && (mace == true && index == true && (axe == false && wand == false)))
        {
            Inventory.RemoveAt(0);
            Debug.Log("item dropped");
            mace = false;
            index = false;
            Instantiate(armas[0], dropPoint.transform.position, dropPoint.transform.rotation);
        }
    }

    void AnadirAxe()
    {
        if (axe == true && index1 == false && (mace == false && wand == false))
        {
            GrabAxe?.Invoke();
            Inventory.Add(armas[1]);
            Debug.Log("Axe anadido");
            index1 = true;
        }
        if (Input.GetKeyDown(KeyCode.Q) && (axe == true && index1 == true && (mace == false && wand == false)))
        {
            Inventory.RemoveAt(0);
            Debug.Log("item dropped");
            axe = false;
            index1 = false;
            Instantiate(armas[1], dropPoint.transform.position, dropPoint.transform.rotation);
        }
    }

    void AnadirWand()
    {
        if (wand == true && index2 == false && (axe == false && mace == false))
        {
            GrabWand?.Invoke();
            Inventory.Add(armas[2]);
            Debug.Log("Wand anadido");
            index2 = true;
        }
        if (Input.GetKeyDown(KeyCode.Q) && (wand == true && index2 == true && (mace == false && axe == false)))
        {
            Inventory.RemoveAt(0);
            Debug.Log("item dropped");
            wand = false;
            index2 = false;
            Instantiate(armas[2], dropPoint.transform.position, dropPoint.transform.rotation);
        }
    }

    void EliminarObjeto()
    {

    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mace")
        {
            if (mace == false && index == false && (axe == false && wand == false))
            {
                mace = true;
                Destroy(collision.gameObject);
            }

        }
        if (collision.gameObject.tag == "Axe")
        {
            if (axe == false && index1 == false && (mace == false && wand == false))
            {
                axe = true;
                Destroy(collision.gameObject);
            }

        }
        if (collision.gameObject.tag == "Wand")
        {
            if (wand == false && index2 == false && (axe == false && mace == false))
            {
                wand = true;
                Destroy(collision.gameObject);
            }

        }
    }
}
