using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour
{
    public VirtualButtonBehaviour vb, actionBtn;
    public GameObject info;
    bool pressed = false;
    // Start is called before the first frame update
    void Start()
    {
        // btn = GameObject.Find("VirtualButton");
        vb.RegisterOnButtonPressed(btnPressed);
        vb.RegisterOnButtonReleased(btnReleased);
    }

    private void btnReleased(VirtualButtonBehaviour obj)
    {

       // info.SetActive(true);
        
    }

    private void btnPressed(VirtualButtonBehaviour obj)
    {
        if (pressed == false)
        {
            info.SetActive(true);
            pressed = true;
        }
        else
        {
           info.SetActive(false);
             pressed = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
