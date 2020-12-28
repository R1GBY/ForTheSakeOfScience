using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletText : MonoBehaviour
{
    public Text bt;

    private void Update()
    {
        if (FindObjectOfType<fire>()!=null)
        {
            bt.text = "Bullet: " + FindObjectOfType<fire>().ammo;
        }
        else
        {
            bt.text = "Bullet: 0";
        }
       
    }
}
