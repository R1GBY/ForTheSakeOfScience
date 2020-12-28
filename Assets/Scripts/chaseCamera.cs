using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseCamera : MonoBehaviour
{
    public Transform MainRb;
   
    void Update()
    {
        transform.position = new Vector3(MainRb.position.x,MainRb.position.y,MainRb.position.z-10f);
    }
}
