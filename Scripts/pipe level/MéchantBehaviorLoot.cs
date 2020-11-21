using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MéchantBehaviorLoot : MonoBehaviour
{
    public GameObject laser;
    public GameObject Loot;
    public GameObject Mechant;
   
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
        Loot.transform.position = new Vector2(Mechant.transform.position.x,Mechant.transform.position.y);

    }
}
