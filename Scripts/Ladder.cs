using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    private float inputVertical;
    private Rigidbody2D rb;
    public float speed;
    private Collider2D COL;
    private bool trigered;
    void Start()


    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
        if (trigered == true && COL != null)
        {
            COL.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            inputVertical = Input.GetAxisRaw("Vertical");
            COL.GetComponent<Rigidbody2D>().velocity = new Vector2(COL.gameObject.GetComponent<Rigidbody2D>().velocity.x, inputVertical * speed);
        }
      

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {

            COL = col;
            trigered = true;
            COL.gameObject.GetComponent<PersonnageBehavior>().vitesse /= 2;


        }

    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            trigered = false;
            COL.gameObject.GetComponent<PersonnageBehavior>().vitesse *= 2;
            COL.gameObject.GetComponent<Rigidbody2D>().gravityScale = 2;
        }


    }


}