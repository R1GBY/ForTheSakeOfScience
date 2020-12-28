using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using UnityEditor;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform target;
    public float healthBar=100f;
    private float movementSpeed = 5f;
    public Animator animRight;
    public bool canAttackPlayer = false;
    public bool canWalkPlayer = false;
    private float distance=10f;
    public GameObject dusenEsya;
    public bool colorchange = false;
    public ParticleSystem part;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("targetHit").GetComponent<Transform>();
    }

    void Update()
    {

        if (colorchange)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            Invoke("colorfal",0.5f);
        }
        
        distance = Mathf.Abs(Vector2.Distance(transform.position, target.position));
      
        if (canWalkPlayer)
        {
            target = GameObject.FindGameObjectWithTag("pl").GetComponent<Transform>();
        }
        if (distance<=15f)
        {
            canAttackPlayer = true;
        }
        else
        {
            canAttackPlayer = false;
            transform.position = Vector2.MoveTowards(transform.position, target.position, Time.deltaTime * movementSpeed);
        }
        
        if (healthBar<=0f)
        {
            Death();
        }

    }
    void Death()
    {
        float a = UnityEngine.Random.Range(0, 3);
        if (a==2)
        {
            Instantiate(dusenEsya, transform.position, Quaternion.identity);
        }
        Instantiate(part, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Bullet"))
        {
            canWalkPlayer = true;
            colorchange = true;
        }
    }

    void colorfal()
    {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            colorchange = false;
    }
}
