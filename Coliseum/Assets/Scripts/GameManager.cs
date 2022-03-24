using System.Net.Mime;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject Hud;
    private bool cursorLockSwitch;
    public bool pause;

    private void Awake()
    {
        pause = false;

        /*
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
    */}
    void Update()
    {
        pause = Hud.gameObject.GetComponent<HUDManager>().alreadyPaused;
        if (pause == false && cursorLockSwitch == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            cursorLockSwitch = true;
        }
        if (pause == true && cursorLockSwitch == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            cursorLockSwitch = false;
        }
    }
}
