using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr2 : MonoBehaviour
{
    public GameObject esc3;

    public bool cs = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cs)
        {
            esc3.SetActive(true);
        }
    }
}
