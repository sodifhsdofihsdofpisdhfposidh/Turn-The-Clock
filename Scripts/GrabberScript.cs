using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberScript : MonoBehaviour
{

    public bool grabbed;
    public float distance = 0.5f;
    public Transform holdpoint;
    public float throwforce;

    private RaycastHit2D hit;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {


            if (!grabbed)
            {
                // Prendre un objet.
                Physics2D.queriesStartInColliders = false;
                hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance / 2);

                if (hit.collider != null && hit.collider.tag == "grabbable")
                {
                    grabbed = true;
                }
            }
            else
            {
                // Jeter un objet.
                grabbed = false;
                Rigidbody2D rb = hit.collider.gameObject.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.constraints = RigidbodyConstraints2D.None;
                    rb.velocity = new Vector2(transform.localScale.x, 1) * throwforce;
                }
            }
        }
    }

    // Affiche la portée du grab du joueur.
    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * distance / 2);
    }

    // FixedUpdate() est utilisé à la place de Update() pour manipuler les RigidBody.
    void FixedUpdate()
    {
        if (grabbed)
        {
            Rigidbody2D rb = hit.collider.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.MovePosition(holdpoint.position);
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }

}