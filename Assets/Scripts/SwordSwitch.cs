using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwitch : MonoBehaviour
{
    public bool itsGun = true;
    public Animator anim;

    public GameObject gun;

    public GameObject sword;
    
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            gun.SetActive(true);
            sword.SetActive(false);
            anim.SetBool("gunbool",true);
            itsGun = true;
        }
        else if (Input.GetKeyDown("e"))
        {
            sword.SetActive(true);
            gun.SetActive(false);
            anim.SetBool("gunbool",false);
            itsGun = false;
        }
        
    }
}
