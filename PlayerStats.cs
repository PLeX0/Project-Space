using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public float healthProcent;

    public float reloadSpeed;

    public int damage;

    //0.10 = 100%
    public GameObject blackBar;
    public GameObject redBar;




    void Start()
    {
        maxHealth = 100;
        health = maxHealth;
        
    }


    void Update()
    {
        healthProcent = health / maxHealth * 100;

        float redbarx = healthProcent * 0.001f;
        redBar.transform.localScale = new Vector3(redbarx, 0.1f, 0.1f);

    
    }

}
