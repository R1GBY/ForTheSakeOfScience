using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class entranceScript : MonoBehaviour
{
    public void canStart()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void canquit()
    {
        Application.Quit();
    }
}
