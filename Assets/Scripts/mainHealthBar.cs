using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainHealthBar : MonoBehaviour
{
    private Image healthimage;
    public float MaxHealth = 100f;
    private float currentHealth = 100f;
    void Start()
    {
        healthimage = GetComponent<Image>();
    }


    void Update()
    {
        currentHealth = FindObjectOfType<movement>().healthBar;
        healthimage.fillAmount = currentHealth / MaxHealth;
    }
}
