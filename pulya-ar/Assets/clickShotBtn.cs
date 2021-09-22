using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickShotBtn : MonoBehaviour
{
    Animator anim;
    public GameObject katya;
    void Start()
    {
        
    }
   public void startAnim()
    {
        anim = katya.GetComponent<Animator>();
        anim.Play("fire");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
