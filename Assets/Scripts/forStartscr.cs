using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forStartscr : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        Invoke("fstart",30f);
    }

    private void fstart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
