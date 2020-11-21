using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuer : MonoBehaviour
{
    public bool isActived;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") && isActived)
        {
            Destroy(col.gameObject);
            Application.LoadLevel(0);
        }



    }
}
