﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWall : MonoBehaviour
{
    public Animator animator;
    public GameObject plateforme;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("grabbable"))
        {
            animator.SetBool("IsOn", true);
            plateforme.SetActive(false);

        }

    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("grabbable"))
        {
            animator.SetBool("IsOn", false);
            plateforme.SetActive(true);
        }
    }

}



