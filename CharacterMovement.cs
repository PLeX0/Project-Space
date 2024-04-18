using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;


public class CharacterMovement : MonoBehaviour
{


    float lockPos = 0;
    public float maxMoveSpeed = 4f;
    public float moveSpeed;
    public float currentMoveSpeed;

    public float jumpHeight = 50f;   
    public Rigidbody2D rb;
    public float jumpTime = 1f;

    public Camera Cam;
    public bool canMove;

    public GroundCheck groundCheck;
    public bool isGround;


    void Start()
    {
      
    }


    void Update()
    {
        if (isGround)
            jumpTime = 0.5f;

       isGround = GameObject.Find("GroundCheck").GetComponent<GroundCheck>().isGround;

        moveSpeed = maxMoveSpeed;

        if (Input.GetKeyDown(KeyCode.H))
        {
            if (Cam.orthographicSize >= 4)
            {
                Cam.orthographicSize = 4;
            }
            Cam.orthographicSize += 1;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (Cam.orthographicSize <= 2)
            {
                Cam.orthographicSize = 2;
            }
            Cam.orthographicSize -= 1;
        }

        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);


      
        if (Input.GetKey(KeyCode.W))
        {
            if (jumpTime > 0)
            {
                jumpTime -= Time.deltaTime;
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
            }
            else if(jumpTime<=0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -moveSpeed);
            }



        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            jumpTime = 0f;

        }

        if (Input.GetKey(KeyCode.S))
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -moveSpeed);
            currentMoveSpeed = moveSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            currentMoveSpeed = 0f;

        }

        if (Input.GetKey(KeyCode.D))
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            currentMoveSpeed = moveSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            currentMoveSpeed = 0f;

        }

        if (Input.GetKey(KeyCode.A))
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            currentMoveSpeed = moveSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            currentMoveSpeed = 0f;

        }
    }


   


}

    

