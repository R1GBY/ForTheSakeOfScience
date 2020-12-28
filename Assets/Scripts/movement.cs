using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed = 15f;
    public float healthBar = 100f;
    public float dashSpeed;
    public bool cantrigger = false;
    public ParticleSystem partikıl;
    public bool dashbool = false;
    public AudioSource aso;
    public GameObject wep;
    public ParticleSystem partikıl2;
    public GameObject esc;
    private bool escbool = false;
    public GameObject esc2;
 

    private void Update()
    {
        if (healthBar<=0f)
        {
           esc2.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) && !escbool)
        {
            esc.SetActive(true);
            escbool = true;
        }
        else if (escbool && Input.GetKeyDown(KeyCode.Escape))
        {
            esc.SetActive(false);
            escbool = false;
        }
        
        healthBar = Mathf.Clamp(healthBar, 0, 100f);
        if (FindObjectOfType<armRotate>().canTurn)
        {
            transform.rotation = Quaternion.Euler(0,180,0);
            wep.GetComponent<SpriteRenderer>().flipY = true;
        }
        else
        { 
            transform.rotation = Quaternion.Euler(0,0,0);
            wep.GetComponent<SpriteRenderer>().flipY = false;
        }
        if (!dashbool)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);
            transform.position += movement*movementSpeed*Time.deltaTime;
        }
        if (Input.GetMouseButtonDown(0) && !FindObjectOfType<SwordSwitch>().itsGun)
        {
            if (FindObjectOfType<armRotate>().canTurn)
            {
                Instantiate(partikıl2, transform.position, Quaternion.Euler(transform.rotation.x,transform.rotation.y,180+FindObjectOfType<armRotate>().angle));
            }

            else if (!FindObjectOfType<armRotate>().canTurn)
            {
                Instantiate(partikıl, transform.position, Quaternion.Euler(transform.rotation.x,transform.rotation.y,FindObjectOfType<armRotate>().angle));
            }
            dashbool = true;
            Invoke("Dash",0.3f);
        }
    }
    public void Dash()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.position = new Vector2(Mathf.Min(mousePos.x,12)+transform.position.x,Mathf.Min(mousePos.y,12)+transform.position.y);
        cantrigger = true;
        dashbool = false;
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("EnemyBullet"))
        {
            aso.Play();
            Destroy(other.gameObject);
            healthBar -= 5f;
        }
    }
}
