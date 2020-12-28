using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordRotate : MonoBehaviour
{
    public Transform rot;
    
    void Update()
    {
        transform.rotation = rot.rotation;
    }
}
