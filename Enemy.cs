using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Material onHitEffect;
    private Material defaultEffect;
    
    public int health;
    public int maxHealth;
    public float movementSpeed;
    public int damage;

    private float onHitEffectTimer = 0.2f;
    private bool isOnHitEffect;



    public PlayerStats playerStats;


    void Start()
    {
        maxHealth = 10;

        defaultEffect = GetComponent<SpriteRenderer>().material;      
        health = maxHealth;
        isOnHitEffect = false;
    }


    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);

        if (health<=0)
        {
            
            Destroy(gameObject);
        }

       if(isOnHitEffect)
        {
            onHitEffectTimer -= Time.deltaTime;
            if(onHitEffectTimer<=0)
            {
                GetComponent<SpriteRenderer>().material = defaultEffect;
                isOnHitEffect = false;
                onHitEffectTimer = 0.2f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {           
            OnHitEffect();         
        }
    }

    public void OnHitEffect()
    {
        health -= playerStats.damage;
        GetComponent<SpriteRenderer>().material = onHitEffect;
        isOnHitEffect = true; 
    }





}
