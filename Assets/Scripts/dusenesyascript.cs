using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusenesyascript : MonoBehaviour
{
   public GameObject player;
   private bool yapis = false;
   private Transform tr;
   public bool canhit = false;

   private void Start()
   {
      tr = GameObject.FindGameObjectWithTag("targetHit").GetComponent<Transform>();
   }

   private void Update()
   {
      if (yapis)
      {
         transform.position = Vector2.MoveTowards(transform.position,tr.position,Time.deltaTime*10f);
      }
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.tag.Equals("pl") && !canhit)
      {
         yapis = true;
         FindObjectOfType<movement>().healthBar += 25f;
         canhit = true;
      }
      if (other.gameObject.tag.Equals("targetiHit"))
      {
         yapis = false;
         Destroy(gameObject);
      }
   }
}
