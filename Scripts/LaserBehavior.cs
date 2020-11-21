using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class LaserBehavior : MonoBehaviour
{
    public Transform origine;
    public Transform destination;
    private float dist;
    public GameObject shield;
    void Start()
    {


       



    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnTriggerEnter2D(Collider2D col)

    {
        if (col.gameObject.CompareTag("Player"))
        {
            Vector2 pointA = origine.position;
            Vector2 pointB = destination.position;




            GetComponent<LineRenderer>().SetPosition(0, pointA);
            GetComponent<LineRenderer>().SetPosition(1, pointB);
            StartCoroutine(Delai());

        }





      


    }
    IEnumerator Delai()
    {

        Vector2 pointA = origine.position;
        Vector2 pointB = destination.position;
        yield return new WaitForSeconds(.125f);
        
        
        if (shield.activeInHierarchy == false)
        {
            Destroy(destination.gameObject);
            Application.LoadLevel(0);
        }
        else
        {
            shield.SetActive(false);

            GetComponent<LineRenderer>().SetPosition(1, pointA);
            yield return new WaitForSeconds(3);

            pointA = origine.position;
            pointB = destination.position;
            GetComponent<LineRenderer>().SetPosition(1, pointB);
            yield return new WaitForSeconds(.125f);
            
            Application.LoadLevel(0);
            GetComponent<LineRenderer>().SetPosition(1, pointA);
        }
    }
    
}
