using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehavior : MonoBehaviour
{
    public Sprite sprite;
    
    
    void Start()
    {
        GetComponent<Animator>().enabled = false;
        StartCoroutine(Delai());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    IEnumerator Delai()
    {
        print("yo");
        yield return new WaitForSeconds(2f);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(3, 0);
        GetComponent<Animator>().enabled = true;
        
        GetComponent<Animator>().SetBool("IsRuning", true);

        
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(3, 5);
        GetComponent<Animator>().SetBool("IsRuning", false);
        yield return new WaitForSeconds(.5f);
        gameObject.SetActive(false);
    }
 
}
