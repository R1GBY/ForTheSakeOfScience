using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunScript : MonoBehaviour
{
    public GameObject enemyBullet;
    private float enemyShootTime = 0f;
    public Transform FirePoint;
    public Transform firepoint2;
    
    void Update()
    {
        enemyShootTime += Time.deltaTime;
        if (enemyShootTime >= 3f)
        {
            shoot();
            enemyShootTime = 0f;
        }
    }
    public void shoot()
    {
        GameObject ebull = Instantiate(enemyBullet, FirePoint.position, Quaternion.identity) as GameObject;
        Vector2 goBullet = new Vector2(firepoint2.position.x-FirePoint.position.x,firepoint2.position.y-FirePoint.position.y);
        ebull.GetComponent<Rigidbody2D>().AddForce(0.05f*goBullet,ForceMode2D.Impulse);
    }
}
