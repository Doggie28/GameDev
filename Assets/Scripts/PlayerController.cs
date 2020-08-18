using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   


    public Animator anim;
    public Rigidbody2D rb;
    public bool isGrounded;
    public Transform groundPoint;

    public LayerMask groundLayer;
    public GameObject deathEffect;
    public Transform effectPosition;
    public GameObject gameOver;
    
    public int jumpForce;
    // Start is called before the first frame update
    //Will be called once
    void Start()
    {
        
    }



    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapPoint(groundPoint.position, groundLayer);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded )
        {
            anim.SetTrigger("Jump");
            rb.AddForce(Vector2.up * jumpForce);
        }
        anim.SetFloat("yVelocity", rb.velocity.y);
        anim.SetBool("isGrounded", isGrounded);
    }
   
    public void GameOver()
    {
        Instantiate(deathEffect, effectPosition.position, Quaternion.identity);
        gameOver.SetActive(true);
        Destroy(gameObject);
    }
}//EndClass
