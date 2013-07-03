using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	
	public float speed = 10f;
	public float jumpHeight = 5f;
	public float mouseSensitivity = 5f;
	// Use this for initialization
	
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0.1){

			rigidbody.AddForce(transform.forward * speed * Input.GetAxis("Vertical"));
		}
		
			if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1){
			 rigidbody.AddForce(transform.right* speed * Input.GetAxis("Horizontal"));
		}
		
		if(Input.GetKeyDown(KeyCode.Space)){
		rigidbody.AddForce(Vector3.up * jumpHeight );	
		}
		
		if (Mathf.Abs(Input.GetAxis("Mouse X")) > 0.1){
		transform.Rotate (0f, Input.GetAxis("Mouse X") * mouseSensitivity , 0f);	
		}
	}
}
