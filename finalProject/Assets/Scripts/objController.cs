using UnityEngine;
using System.Collections;

public class objController : MonoBehaviour {
	
	public float speed = 10f;
	public Transform target;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	    if(Input.GetKey (KeyCode.W)){	
			rigidbody.AddForce (transform.forward.normalized * speed * Time.deltaTime, ForceMode.VelocityChange);	
		}
		if(Input.GetKey (KeyCode.S)){
		rigidbody.AddForce (-transform.forward.normalized * speed * Time.deltaTime, ForceMode.VelocityChange);	
		}
		if(Input.GetKey (KeyCode.A)){
		rigidbody.AddForce (-transform.right.normalized * speed * Time.deltaTime, ForceMode.VelocityChange);	
		}
		if(Input.GetKey (KeyCode.D)){
		rigidbody.AddForce (transform.right.normalized * speed * Time.deltaTime, ForceMode.VelocityChange);	
		}
		
		transform.LookAt(target);
		
		
	}
}
