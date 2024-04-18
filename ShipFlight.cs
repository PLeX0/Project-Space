using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class ShipFlight : MonoBehaviour
{

    public float maxMoveSpeed = 4f;
    public float moveSpeed;
    public float currentMoveSpeed;

    public Camera Cam;
    

    public GameObject ship;
    public Rigidbody2D rigidbody2d;



    void Start()
    {
        
    }



    void Update()
    {
        

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
       


        //CONTROLS


        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2d.AddForce(transform.up * maxMoveSpeed * 15f);
           
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            currentMoveSpeed = 0f;
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody2d.AddForce(-transform.up * maxMoveSpeed * 15f);

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            currentMoveSpeed = 0f;
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            ship.transform.Rotate(0f, 0f, -1f);
           
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            currentMoveSpeed = 0f;
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            ship.transform.Rotate(0f, 0f, 1f);
          
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            currentMoveSpeed = 0f;
          
        }


        
    }

   

    

    
}
