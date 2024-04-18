using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public BoxCollider2D bulletCollider;

    public Enemy enemy;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
            Destroy(bullet, 0.01f);
        if(collision.CompareTag("enemy"))
        {           
                Destroy(bullet, 0.01f);
        }
    }
}
