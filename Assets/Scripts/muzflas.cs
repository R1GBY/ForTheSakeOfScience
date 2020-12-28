using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzflas : MonoBehaviour
{
    public ParticleSystem partikıl;

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<fire>().attacking)
        {
            Instantiate(partikıl, transform.position, Quaternion.identity);
        }
    }
}
