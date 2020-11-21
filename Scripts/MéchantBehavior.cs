using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MéchantBehavior : MonoBehaviour
{
    public GameObject laser;
   
    void Start()
        
       
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D()
    {





        Destroy(laser);
        Destroy(gameObject);

    }
}
