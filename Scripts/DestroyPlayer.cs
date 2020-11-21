using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyPlayer : MonoBehaviour
{
    // Start is called before the first frame update
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
            Destroy(col.gameObject);
            Application.LoadLevel(0);
        }
    }
}
