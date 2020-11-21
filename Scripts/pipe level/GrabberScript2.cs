using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberScript2 : MonoBehaviour {

	public bool grabbed;
	RaycastHit2D hit;
	public float distance=3f;
	public Transform holdpoint;
	public float throwforce;
	public LayerMask notgrabbed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.E))
		{	


			if(!grabbed)
			{
				Physics2D.queriesStartInColliders=false;
				hit = Physics2D.Raycast(transform.position,Vector2.right*transform.localScale.x,distance);
				print(hit.collider);
				if(hit.collider!=null && hit.collider.tag=="grabbable")
				{
					grabbed=true;
				}

			} else if(!Physics2D.OverlapPoint(holdpoint.position,notgrabbed))
			{
				grabbed=false;
				Rigidbody2D rb = hit.collider.gameObject.GetComponent<Rigidbody2D>();				
				if(rb!=null)
				{

					rb.velocity= new Vector2(transform.localScale.x,1)*throwforce;
					rb.freezeRotation=false;
				}

			}


		}

		if (grabbed) {
					hit.collider.gameObject.transform.position = holdpoint.position;
					//hit.collider.gameObject.transform.Rotate(0,0,-hit.collider.gameObject.transform.rotation.z);
					Rigidbody2D rb = hit.collider.gameObject.GetComponent<Rigidbody2D>();
					if (rb!=null) {
					rb.freezeRotation=true;
					}
				}

	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawLine(transform.position,transform.position+Vector3.right*transform.localScale.x*distance);
	}

}
