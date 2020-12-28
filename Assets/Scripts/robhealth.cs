using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class robhealth : MonoBehaviour
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
        currentHealth = FindObjectOfType<BossPassive>().healthBar;
        healthimage.fillAmount = currentHealth / MaxHealth;
    }
}
