using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PersonnageBehavior : MonoBehaviour
{
    private bool isGrounded = false;
    public Rigidbody2D rb;
    public float vitesse;
    public Animator animator;
    public GameObject dialogue;
    public float jump;
    private float t;
    public float SautInitial;
    public GameObject titre;
    public GameObject player;
   
   
    
    void Start()
    {
        
        SautInitial = jump;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("z") && isGrounded)
        {
            Jump();
            StartCoroutine(Delai());

        }
        if (Stage.stage == 0)
        {
            float h = Input.GetAxisRaw("Horizontal") * vitesse;
            rb.velocity = new Vector2(h, rb.velocity.y);
            if (Input.GetKeyDown("q"))
            {
                animator.SetBool("IsLeft", true);
                transform.localScale = new Vector3(-0.3128078f, transform.localScale.y, 0);

            }
            if (Input.GetKeyDown("d"))
            {
                animator.SetBool("IsLeft", false);
                transform.localScale = new Vector3(0.3128078f, transform.localScale.y, 0);
            }
            
        }

        else if (Stage.stage<6)
        {
            rb.velocity = new Vector2(6, rb.velocity.y);
        }

        if (GetComponent<Rigidbody2D>().velocity.x!=0  && isGrounded)
        {
            
            GetComponent<Animator>().SetBool("IsRuning", true);

        }
        else
        {
            
            GetComponent<Animator>().SetBool("IsRuning", false);
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



    IEnumerator Delai()
    {
        if (jump != 0)
        {
            
            jump = 0;
            yield return new WaitForSeconds(0.4f);
            jump = SautInitial;
        }
        
    }

    IEnumerator Delai2()
    {
        yield return new WaitForSeconds(1);
        dialogue.SetActive(true);
        yield return new WaitForSeconds(2);

        titre.GetComponent<Animator>().SetBool("isEnd", true);
        yield return new WaitForSeconds(1);
        dialogue.SetActive(false);
        player.GetComponent<SpriteRenderer>().flipX = true;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Spyke")
        {
            Destroy(gameObject);
            Stage.stage = 6;
            Application.LoadLevel(0);
            
        }
        else if (col.tag == "Barriere")
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            StartCoroutine(Delai2());
            
           
            

        }
    }

}