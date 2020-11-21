using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PersonnageBehavior2 : MonoBehaviour
{
    private bool isGrounded = false;
    public Rigidbody2D rb;
    public float vitesse;
    public Animator animator;
    public float jump;
    
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        float h = Input.GetAxisRaw("Horizontal") * vitesse;
        rb.velocity = new Vector2(h, rb.velocity.y);
        if (Input.GetKeyDown("q"))
        {
            animator.SetBool("IsLeft", true);
            transform.localScale = new Vector3(-0.15f, 0.15f, 0);
            
        }
        if (Input.GetKeyDown("d"))
        {
            animator.SetBool("IsLeft", false);
            transform.localScale = new Vector3(0.15f, 0.15f, 0);
        }
        if (Input.GetKeyDown("z") && isGrounded)
        {
            Jump();
        }
    }
    void Jump()
    {
        rb.velocity += new Vector2(0, jump);
    }



    public void setIsGrounded(bool boolean)
    {
        this.isGrounded = boolean;
    }

   


}