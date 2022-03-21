using System.Threading;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] GameObject MenuPausa;
    [SerializeField] GameObject MacePanel;
    [SerializeField] GameObject AxePanel;
    [SerializeField] GameObject WandPanel;
    [SerializeField] GameObject[] healthSlotPanels;
    [SerializeField] GameObject[] emptyHealthSlotPanels;
    private int vidaPlayer;
    public bool alreadyPaused;
    //Armas switch bools
    private bool alreadyMace;
    private bool alreadyAxe;
    private bool alreadyWand;
    //Vida switch bools
    private bool vidaSlot5 = true;
    private bool vidaSlot4 = true;
    private bool vidaSlot3 = true;
    private bool vidaSlot2 = true;
    private bool vidaSlot1 = true;
    private float fixedDeltaTime;


void Awake()
{
    Time.timeScale=1;
}
void Start()
{
    Time.timeScale=1;
}

    void Update()
    {
        vidaPlayer = player.gameObject.GetComponent<Health_Damage>().vida;
        MaceSet();
        AxeSet();
        WandSet();


        if (Input.GetKeyDown(KeyCode.Escape) && alreadyPaused == false)
        {
            MenuPausa.SetActive(!MenuPausa.activeSelf);
            Time.timeScale = 0f;
            alreadyPaused = true;
        }
        if (Input.GetKeyDown(KeyCode.Return) && alreadyPaused == true)
        {
            MenuPausa.SetActive(!MenuPausa.activeSelf);
            Time.timeScale = 1f;
            alreadyPaused = false;
        }

        if (vidaPlayer <= 80 && vidaSlot5 == true)
        {
            healthSlotPanels[4].SetActive(!healthSlotPanels[4].activeSelf);
            emptyHealthSlotPanels[4].SetActive(!emptyHealthSlotPanels[4].activeSelf);
            vidaSlot5 = false;
        }
        if (vidaPlayer <= 60 && vidaSlot4 == true)
        {
            healthSlotPanels[3].SetActive(!healthSlotPanels[3].activeSelf);
            emptyHealthSlotPanels[3].SetActive(!emptyHealthSlotPanels[3].activeSelf);
            vidaSlot4 = false;
        }
        if (vidaPlayer <= 40 && vidaSlot3 == true)
        {
            healthSlotPanels[2].SetActive(!healthSlotPanels[2].activeSelf);
            emptyHealthSlotPanels[2].SetActive(!emptyHealthSlotPanels[2].activeSelf);
            vidaSlot3 = false;
        }
        if (vidaPlayer <= 20 && vidaSlot2 == true)
        {
            healthSlotPanels[1].SetActive(!healthSlotPanels[1].activeSelf);
            emptyHealthSlotPanels[1].SetActive(!emptyHealthSlotPanels[1].activeSelf);
            vidaSlot2 = false;
        }
        if (vidaPlayer <= 0 && vidaSlot1 == true)
        {
            healthSlotPanels[0].SetActive(!healthSlotPanels[0].activeSelf);
            emptyHealthSlotPanels[0].SetActive(!emptyHealthSlotPanels[0].activeSelf);
            vidaSlot1 = false;
        }

    }






    private void MaceSet()
    {
        if (player.gameObject.GetComponent<Inventario>().index == true && alreadyMace == false)
        {
            MacePanel.SetActive(!MacePanel.activeSelf);
            alreadyMace = true;
        }
        if (player.gameObject.GetComponent<Inventario>().index == false && alreadyMace == true)
        {
            MacePanel.SetActive(!MacePanel.activeSelf);
            alreadyMace = false;
        }
    }

    private void AxeSet()
    {
        if (player.gameObject.GetComponent<Inventario>().index1 == true && alreadyAxe == false)
        {
            AxePanel.SetActive(!AxePanel.activeSelf);
            alreadyAxe = true;
        }
        if (player.gameObject.GetComponent<Inventario>().index1 == false && alreadyAxe == true)
        {
            AxePanel.SetActive(!AxePanel.activeSelf);
            alreadyAxe = false;
        }
    }

    private void WandSet()
    {
        if (player.gameObject.GetComponent<Inventario>().index2 == true && alreadyWand == false)
        {
            WandPanel.SetActive(!WandPanel.activeSelf);
            alreadyWand = true;
        }
        if (player.gameObject.GetComponent<Inventario>().index2 == false && alreadyWand == true)
        {
            WandPanel.SetActive(!WandPanel.activeSelf);
            alreadyWand = false;
        }
    }




}
