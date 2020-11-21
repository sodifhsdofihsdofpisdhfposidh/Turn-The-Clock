using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior : MonoBehaviour
{
    private Vector3[] tab;
    void Start()
    {
        tab = new Vector3[10];
        remplir();
    }

    // Update is called once per frame
    void Update()
    {
        if (Stage.stage != 0 && Stage.stage<6)
        {
            
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(6, 0);
            
        }
        else if (Stage.stage == 6 && gameObject.GetComponent<Rigidbody2D>().velocity.x >4.7952)
        {
           
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x - .00061f, 0);
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
    public void changer()
    {
        if (1<Stage.stage)
        {
          
            gameObject.transform.position = tab[Stage.stage];
        }
      
    }
    void remplir()
    {
        tab[2] = new Vector3(184, -0.7f, -1);
        tab[3] = new Vector3(294, -0.7f, -1);
        tab[4] = new Vector3(424, -0.7f, -1);
        tab[5] = new Vector3(574, -0.7f, -1);
        tab[6] = new Vector3(714, -0.7f, -1);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Spyke")
        {
            Destroy(col.gameObject);
        }
    }
}
