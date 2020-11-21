using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Stage : MonoBehaviour
{
    public static int stage = 6;
    public Sprite sprite0, sprite1,sprite2,sprite3,sprite4,sprite5,sprite6;
    private Sprite [] tab;
    private Vector3[] tab1;

    void Start()
    {
        tab = new Sprite[10];
        tab1 = new Vector3[10];
        this.remplir();
        transform.localScale = tab1[6];
    }

    // Update is called once per frame
    void Update()
    {
        if (stage == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite0;
            transform.localScale = new Vector3(1.582387f, 1.1400632f, 1) ;
        }

    }
    public void changer()
    {
        
        this.gameObject.GetComponent<SpriteRenderer>().sprite = tab[stage];

        transform.localScale = tab1[stage];

    }
    public void remplir()
    {
        tab[0] = sprite0;
        tab[1] = sprite1;
        tab[2] = sprite2;
        tab[3] = sprite3;
        tab[4] = sprite4;
        tab[5] = sprite5;
        tab[6] = sprite6;


        tab1[1] = new Vector3(1.9f, 2.1f, 1);
        tab1[2] = new Vector3(3.773411f, 3.3794f, 1);
        tab1[3] = new Vector3(0.373411f, 0.5794f, 1);
        tab1[4] = new Vector3(1.573411f, 2.0794f, 1);
        tab1[5] = new Vector3(2.973411f, 2.4794f, 1);
        tab1[6] = new Vector3(1.238733f, 1.371334f, 1);


    }

}
