using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChase : MonoBehaviour
{
    
    public Animator anim;
   
    void Update()
    {
        
        if (FindObjectOfType<movement>().cantrigger)
        {
            anim.SetBool("bool1",true);
            FindObjectOfType<movement>().cantrigger = false;
        }
        else
        {
            anim.SetBool("bool1",false);
        }
        
    }
}