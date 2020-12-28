using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class bossactive : MonoBehaviour
{
    private float pos;
    private Transform player;
    public GameObject gun;
    public float HealthBar = 1000f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("pl").GetComponent<Transform>();
    }
    void Update()
    {
        if (HealthBar<=0f)
        {
            FindObjectOfType<scr2>().cs = true;
        }
        
        pos = player.position.x - transform.position.x;
        if (pos<0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            gun.GetComponent<SpriteRenderer>().flipX = true;
            gun.transform.position = new Vector3(transform.position.x-1.5f,transform.position.y,transform.position.z);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            gun.GetComponent<SpriteRenderer>().flipX = false;
            gun.transform.position = new Vector3(transform.position.x+1.5f,transform.position.y,transform.position.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Bullet"))
        {
            HealthBar -= 20f;
        }
    }
}
