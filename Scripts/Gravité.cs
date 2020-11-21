using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class Gravité : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Pieds"))/*Si les élément rentrant dans le portail ne sont pas les pieds du joueur. */
        {
            {
                collision.gameObject.GetComponent<Rigidbody2D>().gravityScale *=-1; /* La gravité de l'élément est inversée. */
                Vector3 colScale = collision.gameObject.transform.localScale;

                colScale.y *= -1; /* Une conséquence instinctive de l'inversion de gravité est de retourner le personnal verticalement (donc l'axe y). */
                collision.gameObject.transform.localScale = colScale; /* Application de ce qui est dit plus haut. */
                if (collision.gameObject.CompareTag("Player")) /* Si l'élement rentrant dans le portail est le joueur. */
                {

                    collision.gameObject.GetComponent<PersonnageBehavior>().jump = -collision.gameObject.GetComponent<PersonnageBehavior>().SautInitial ; /* La dernière étape est d'inverser la gravité octroyée par les sauts du personnage.  */
                    collision.gameObject.GetComponent<PersonnageBehavior>().SautInitial *= -1; /* Application de ce qui est dit plus haut. */

                }
            }
        }
    }
}


