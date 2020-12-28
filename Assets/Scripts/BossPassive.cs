using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPassive : MonoBehaviour
{
    public float healthBar = 500f;
    private float sayac = 0f;
    public Sprite f0;
    public Sprite f1;
    public Sprite f2;
    public Sprite f3;
    public Sprite f4;
    public bool go1=false;
    public bool go2=false;
    public bool go3=false;
    public bool go4=false;
    public bool go5=false;
    public bool go6 = false;
    public GameObject boss;
    public bool bosscanSpawn = false;
    public GameObject sp;
    public GameObject esc2;
  
    

    private void Update()
    {
        
        healthBar = Mathf.Clamp(healthBar, 0f, 500f);

        if (healthBar<=0f)
        {
            esc2.SetActive(true);
        }
        
        if (sayac<10f)
        {
            go1 = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = f0;
        }
        else if (sayac>=10f && sayac<20f)
        {
            go1 = false;
            go2 = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = f1;
        }

        else if (sayac>=20f && sayac<30f)
        {
            go2 = false;
            go3 = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = f2;
        }
        else if (sayac>=30f && sayac<40f)
        {
            go3 = false;
            go4 = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = f3;
        }
        else if (sayac>=40f && sayac<50f)
        {
            go4 = false;
            go5 = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = f4;
        }
        else if(sayac==50f)
        {
            bosscanSpawn = true;
        }
        else if (sayac>50f && bosscanSpawn)
        {
            sp.SetActive(false);
            bosscanSpawn = false;
            go5 = false;
            go6 = true;
            Vector2 a = new Vector2(transform.position.x,transform.position.y-12f);
            Instantiate(boss, transform.position, Quaternion.identity);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
       
        
        if (sayac % 10 == 0)
        {
            healthBar += 100f;
            sayac++;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("EnemyBullet"))
        {
            Destroy(other.gameObject);
            healthBar -= 20f;
        }
        if (other.tag.Equals("DusenNesne"))
        {
            Destroy(other.gameObject);
            sayac++;
            healthBar += 20f;
        }
    }
}
