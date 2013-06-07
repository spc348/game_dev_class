using UnityEngine;
using System.Collections;

public class charMotor : MonoBehaviour {
	
	public float speed = 5f;
	public float turnRate = 5f;
	public float jumpRate = 5f;
	public float rayLength = 1f;
	CharacterController controller;
	
	// Use this for initialization
	void Start () {
		
	controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0.1){
			//rigidbody.AddForce (transform.forward * speed * Input.GetAxis("Vertical"), ForceMode.VelocityChange);
			controller.SimpleMove(transform.forward * speed * Input.GetAxis("Vertical"));
		}
		
			if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1){
			  transform.Rotate (0f,Input.GetAxis ("Horizontal") * turnRate,0f);	
		}
		
		if (Input.GetMouseButton(1) && controller.isGrounded){
			Debug.Log ("grounded");
			controller.Move(Vector3.up*jumpRate);
		}
	}
}
