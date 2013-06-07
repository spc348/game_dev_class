using UnityEngine;
using System.Collections;

public class rigidbodyMotor : MonoBehaviour {
	
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
		
		if(Input.GetMouseButton(1) && grounded){
			rigidbody.AddForce(transform.up * jumpRate, ForceMode.Impulse);
		}
		
		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0.1){
			rigidbody.AddForce (transform.forward * speed * Input.GetAxis("Vertical"), ForceMode.VelocityChange);
		}
		
			if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1){
			  transform.Rotate (0f,Input.GetAxis ("Horizontal") * turnRate,0f);
			
		}
	
	}
}
