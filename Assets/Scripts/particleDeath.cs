using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleDeath : MonoBehaviour
{
    void Update()
    {
        Invoke("destroyParticle",2f);   
    }

    public void destroyParticle()
    {
        Destroy(gameObject);
    }
}