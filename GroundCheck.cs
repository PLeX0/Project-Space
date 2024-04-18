using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public BoxCollider2D groundCheckCollider;

    public bool isGround = true;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = false;

    }
}
