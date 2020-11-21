using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutonState : MonoBehaviour
{
    public Animator boutonAnimator;
    public Animator croixAnimator;

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
            boutonAnimator.SetBool("IsOn", true);
            croixAnimator.SetInteger("CroixEtat", croixAnimator.GetInteger("CroixEtat") + 1);

        }

    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("grabbable"))
        {
            boutonAnimator.SetBool("IsOn", false);
            croixAnimator.SetInteger("CroixEtat", croixAnimator.GetInteger("CroixEtat") - 1);
        }

    }

}




