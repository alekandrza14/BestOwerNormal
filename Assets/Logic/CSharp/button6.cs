﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
public class portallNumer
{
    public static string Portal = "";
}

public class button6 : MonoBehaviour
{

    public int id;
    public bool enter;
    public bool notsave;
    public bool iaw;
    public string Portal;
    public bool p3;
    public bool p4;
    public bool p5;
    public Collider other;
    public float w;
    public static GameObject TabUse;
    private void Start()
    {
        Init();
        Teleport();
    }

    private void Teleport()
    {
        if (portallNumer.Portal == Portal)
        {
            Debug.Log("portaltelep "+ Portal);
            GameManager.load(transform);
            portallNumer.Portal = "";
        }
    }

    private void Init()
    {
        if (iaw)
        {
            Portal = "iaw";
        }
        if (p3)
        {
            Portal = "p3";
        }
        if (p4)
        {
            Portal = "p4";
        }
        if (p5)
        {
            Portal = "p5";
        }
    }

    public void startcol()
    {
        enter = true;
        
    }
    
    private void OnTriggerEnter(Collider s)
    {
        if (s.gameObject.tag == "Player")
        {
            TabUse = Instantiate(Resources.Load<GameObject>("ui/info/PressTabToUse"));
            startcol();



        }
    }
   
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (enter)
            {
                
                
                portallNumer.Portal = Portal;
                GameManager.chargescene(id);

            }
        }
    }
    private void OnTriggerExit(Collider s)
    {
        if (s.gameObject.tag == "Player")
        {
            if (TabUse) Destroy(TabUse);
            enter = false;
            PlayerPrefs.SetString("text", "");
            other = s;


        }
    }
    
}

