using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossGun : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target;
    public GameObject bullet;
    public Transform firePos;
    public float bulletSpeed = 10f;
    public AudioSource asorc;
    private float btime = 0f;
    private float roketTime = 0f;
    public GameObject rokett;
    void Update()
    {
        roketTime += Time.deltaTime;
        btime += Time.deltaTime;
        target = GameObject.FindGameObjectWithTag("pl").GetComponent<Transform>();
        if (btime>0.5f)
        {
            attack();
            btime = 0f;
        }

        if (roketTime>=5f)
        {
            roket();
            roketTime = 0f;
        }
    }
    void attack()
    {
        asorc.Play();
        Vector2 attackPos = new Vector2(target.position.x-firePos.position.x,target.position.y-firePos.position.y);
        GameObject bulletgo = Instantiate(bullet, firePos.position, Quaternion.identity) as GameObject;
        bulletgo.GetComponent<Rigidbody2D>().AddForce(attackPos*bulletSpeed,ForceMode2D.Impulse);
    }

    void roket()
    {
        Instantiate(rokett, firePos.position, Quaternion.identity);
    }
}
