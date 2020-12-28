using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscr : MonoBehaviour
{
    public ParticleSystem partikıl;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            other.gameObject.GetComponent<EnemyScript>().healthBar -=25f;
        }
        Instantiate(partikıl, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
