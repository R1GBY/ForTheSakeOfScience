using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    
    public Transform AttackPoint;
    public float Range = 3f;
    public LayerMask LayerEnemy;
    public AudioSource voice;
    public AudioSource voice2;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }
            
    }

    void Attack()
    {
        voice.Play();
        Invoke("forvoice",0.2f);
        Vector2 pos = new Vector2(transform.position.x,transform.position.y);
        Collider2D[] DamagedEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, Range, LayerEnemy);
        foreach (Collider2D enemy in DamagedEnemies)
        {
            if (enemy.tag.Equals("Enemy"))
            {
                enemy.GetComponent<EnemyScript>().canWalkPlayer = true;
                enemy.GetComponentInParent<EnemyScript>().healthBar -= 50f;    
            }
            else if (enemy.tag.Equals("boss"))
            {
                enemy.GetComponent<bossactive>().HealthBar -= 30f;
            }
            
        }
    }

    void forvoice()
    {
        voice2.Play();
    }
    
}
