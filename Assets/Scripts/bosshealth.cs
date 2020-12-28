using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bosshealth : MonoBehaviour
{
    private Image healthimage;
    public float MaxHealth = 500f;
    private float currentHealth = 100f;
    void Start()
    {
        healthimage = GetComponent<Image>();
    }
    
    void Update()
    {
        currentHealth = FindObjectOfType<bossactive>().HealthBar;
        healthimage.fillAmount = currentHealth / MaxHealth;
    }
}
