using UnityEngine;
using System.Collections;

public class clickToMoveRigidBody : MonoBehaviour {
	//assign variable in inspector
    public float speed = 5f;
    Vector3 destination= Vector3.zero;
	public Rigidbody rbody;

	
	// Use this for initialization
	void Start () {
					destination =  rbody.transform.position;
	}
	void Update(){
	
		RaycastHit rayHit = new RaycastHit();
		
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		if ( Input.GetMouseButton(0) && Physics.Raycast (ray, out rayHit, 1000000f)){
			Debug.Log ("ray sent");
			destination = rayHit.point;
		}
			
		    Vector3 moveVector = destination - rbody.transform.position;
			Debug.DrawRay(rbody.transform.position, moveVector);
			rbody.AddForce(moveVector.normalized * speed * Time.smoothDeltaTime,ForceMode.Impulse);
		}
		
		
	}
	
