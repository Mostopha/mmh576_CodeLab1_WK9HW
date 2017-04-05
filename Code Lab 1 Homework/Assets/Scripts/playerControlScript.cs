﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControlScript : MonoBehaviour
{


    public float speed;
    public float jumpAmount;
    public float glideAmount;

    
    public KeyCode downKey = KeyCode.S;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode jumpKey = KeyCode.Space;
    
    

    public Rigidbody2D rb;
    public Rigidbody2D rocket;

    private bool onGround = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        Move(Vector3.down, downKey);
        Move(Vector3.left, leftKey);
        Move(Vector3.right, rightKey);
        Jump();
       
    }

    void Move(Vector3 dir, KeyCode key)
    {

        if (Input.GetKey(key))
        {
            transform.Translate(dir * speed * Time.deltaTime);
        }

    }

    void Jump()
    {
        

        if (Input.GetKeyDown(jumpKey) && onGround == true)
        {
            rb.AddForce(Vector3.up*jumpAmount);
            onGround = false;

        }
        else if (Input.GetKeyDown(jumpKey))
        {
            rb.gravityScale = glideAmount;
        }

        else if (Input.GetKeyUp(jumpKey))
        {
            rb.gravityScale = 1;
        }




    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Ground")
        {
            onGround = true;
        }
        

      
    }

   


}
