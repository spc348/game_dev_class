using UnityEngine;
using System.Collections;

public class physicsScriptPrac : MonoBehaviour {

	
	public float speed = 5f;
	public float turnRate = 5f;
	public float jumpRate = 5f;
	public float rayLength = 0.1f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		bool grounded = Physics.Raycast(transform.position, -transform.up, rayLength);
		
		if (Input.GetButtonDown ("Jump") && grounded){
			rigidbody.AddForce (transform.up * jumpRate, ForceMode.Impulse);
		}
		
	}
	
	// physics is not run on update. it has its own update thing called FixedUpdate
	void FixedUpdate(){
//		if (Input.GetKey(KeyCode.W)){
//			Debug.Log (transform.forward.ToString ());
//			rigidbody.AddForce (transform.forward * speed, ForceMode.VelocityChange);
//		}
		
		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0.1){
			rigidbody.AddForce (transform.forward * speed * Input.GetAxis("Vertical"), ForceMode.VelocityChange);
		}
		
		if (Input.GetKey(KeyCode.S)){
			//Debug.Log (transform..ToString ());
			//rigidbody.AddForce (transform., ForceMode.VelocityChange);
		}
		
		//used for turning
		if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1){
			//rigidbody.addTorque not used because our capsule is round
			transform.Rotate (0f,Input.GetAxis ("Horizontal") * turnRate,0f);
		}
		
		
		
	}
}
