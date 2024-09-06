using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float movespeed = 5f;
    public float acceleration = 1.2f;
    private Rigidbody2D rb;
    public float jumpForce = 7f;
    private bool isGrounded = true;
    private Animator animator;

  
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        
        movespeed += acceleration * Time.deltaTime;
        transform.Translate(new Vector2(1f,0f) * movespeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            Jump();
            animator.SetBool("jump", true);
            isGrounded = false;
        }

     

    }
    void Jump()
    {
       

        Vector2 velocity = rb.velocity;
        velocity.y = jumpForce;
        rb.velocity = velocity;
        //Debug.Log("Player Jump!");
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            animator.SetBool("jump", false);
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log(collision.transform.name);
        if(collision.gameObject.tag == "GroundParent"){
            Destroy(collision.gameObject, 5f);
        }
    }
   

}