using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimension : MonoBehaviour
{
    public static int stage = 0;
    public Sprite sprite0, sprite1;


    private Sprite[] tab;

    void Start()
    {
        tab = new Sprite[10];

        this.remplir();
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void changer()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = tab[stage];
        transform.localScale = new Vector3(1.9f, 2.1f, 1);

    }
    public void remplir()
    {
        tab[0] = sprite0;
        tab[1] = sprite1;
        
    }
}
