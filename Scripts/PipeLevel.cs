﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLevel : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D()
    {
        player.transform.position = new Vector3(-156.06f, -2, 0); 
    }
}
