﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToProtect : MonoBehaviour
{
    public GameObject buffShield;
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
            Destroy(this.gameObject);
            buffShield.SetActive(true);

        }
    }
}
