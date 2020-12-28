using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class fire : MonoBehaviour
{
    public Transform firePlace;
    public GameObject bullet;
    private float fireRate=8f;
    private float canFireFloat = 0f;
    public Transform goFirePlace;
    public float bulletSpeed = 20f;
    public float ammo = 15f;
    public bool attacking = false;
    public AudioSource asorc;


    private void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= canFireFloat && ammo > 0f)
        {
            canFireFloat = Time.time + 1f / fireRate;
            Shoot();
        }
        else
        {
            attacking = false;
        }

        if (ammo <= 0f)
        {
            Invoke("Reload", 2f);
        }

    }

    public void Shoot()
    {
        asorc.Play();
        attacking = true;
        ammo--;
        GameObject bulletFire = Instantiate(bullet, firePlace.position, Quaternion.identity) as GameObject; 
        Vector2 goFire = new Vector2(goFirePlace.position.x-firePlace.position.x,goFirePlace.position.y-firePlace.position.y);
        bulletFire.GetComponent<Rigidbody2D>().AddForce(bulletSpeed * goFire ,ForceMode2D.Impulse);
    }
    public void Reload()
    {
        ammo = 39f;
    }
}
