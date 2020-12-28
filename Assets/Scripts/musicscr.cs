using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicscr : MonoBehaviour
{
    public AudioSource a1;
    public AudioSource a2;
    public AudioSource a3;
    public AudioSource a4;
    public AudioSource a5;
    public AudioSource a6;

    private void Start()
    {
        a1.Play();
    }

    void Update()
    {
        
        if (FindObjectOfType<BossPassive>().go2 && a1.isPlaying)
        {
            a1.Stop();
            a2.Play();
        }
        else if (FindObjectOfType<BossPassive>().go3 && a2.isPlaying)
        {
            a2.Stop();
            a3.Play();
        }
        else if (FindObjectOfType<BossPassive>().go4 && a3.isPlaying)
        {
            a3.Stop();
            a4.Play();
        }
        else if (FindObjectOfType<BossPassive>().go5 && a4.isPlaying)
        {
            a4.Stop();
            a5.Play();
        }
        else if (FindObjectOfType<BossPassive>().go6 && a5.isPlaying)
        {
            a5.Stop();
            a6.Play();
        }
    }
}
