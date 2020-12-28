using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotateGun : MonoBehaviour
{
    private Transform target;
    public GameObject bullet;
    public Transform firePos;
    public float bulletSpeed = 10f;
    public float time = 0f;
    public AudioSource asorc;
    
    void Update()
    {
        time += Time.deltaTime;
        target = GetComponentInParent<EnemyScript>().target;
        if (GetComponentInParent<EnemyScript>().canAttackPlayer && time >= 2f)
        {
            attack();
        }
    }
    void attack()
    {
        asorc.Play();
        Vector2 attackPos = new Vector2(target.position.x-firePos.position.x,target.position.y-firePos.position.y);
        GameObject bulletgo = Instantiate(bullet, firePos.position, Quaternion.identity) as GameObject;
        bulletgo.GetComponent<Rigidbody2D>().AddForce(attackPos*bulletSpeed,ForceMode2D.Impulse);
        time = 0f;
    }
}
