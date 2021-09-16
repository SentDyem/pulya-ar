using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour
{
    GameObject btn;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("VirtualButton");
        anim = GetComponentInChildren<Animator>();
        btn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(btnPressed);
        btn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(btnReleased);
    }

    private void btnReleased(VirtualButtonBehaviour obj)
    {
        anim.Play("Stop");
    }

    private void btnPressed(VirtualButtonBehaviour obj)
    {
        anim.Play("Take 001");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
