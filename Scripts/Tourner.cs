using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Tourner : MonoBehaviour
{
    private bool onDelai = false;
    public float periode;
    public float coef;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (onDelai == false)
        StartCoroutine(Delai());
        
    }
    IEnumerator Delai()
    {
        onDelai = true;
        yield return new WaitForSeconds(periode);
        for (int i = 0; i < 90; i++)
        {
            
            yield return new WaitForSeconds(0.01f/coef);
            gameObject.transform.Rotate(0,0, 1);
            
        }
        onDelai = false;
    }
    
}

