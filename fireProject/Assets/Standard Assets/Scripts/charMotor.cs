using UnityEngine;
using System.Collections;

public class charMotor : MonoBehaviour {
	
	public static float speed = 10f;
	public static float turnRate = 5f;
	public static float jumpRate = 10f;
	public static float rayLength = .8f;

	
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(-14f,2f,0f);
		rigidbody.drag = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		bool grounded = Physics.Raycast(transform.position, -transform.up, rayLength);
		if(grounded){
		Physics.gravity= new Vector3 (0,-9f,0);	
		}
		
		if (grounded == false){
				Debug.Log(grounded);
			 rigidbody.drag = 0f;	
			 Physics.gravity = new Vector3 (0,-30f,0);
			}
		
	}
	
	void FixedUpdate(){
		
		bool grounded = Physics.Raycast(transform.position, -transform.up, rayLength);
		
		if (Input.GetKeyDown(KeyCode.UpArrow) && grounded){
			Debug.Log (grounded);
			int i = 0;
			for ( i = 0; i < 1; i++){
			rigidbody.AddForce (transform.up * jumpRate, ForceMode.VelocityChange);
			}
		}
		
		if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.UpArrow) && grounded){
			int i = 0;
			for (i = 0; i < 1; i++){
			rigidbody.AddForce (transform.up * jumpRate * 1.1f, ForceMode.VelocityChange);
			}
			
		
		}
		
	if (Input.GetKey(KeyCode.RightArrow)){
			rigidbody.AddForce (transform.right * speed * Time.deltaTime, ForceMode.VelocityChange);
		}
		
		if (Input.GetKey(KeyCode.LeftArrow)){
			rigidbody.AddForce (-transform.right * speed * Time.deltaTime, ForceMode.VelocityChange);
		}
	

	if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftShift)){
			rigidbody.AddForce (transform.right * speed * 2 * Time.deltaTime, ForceMode.VelocityChange);
		}
		
		if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.LeftShift)){
			rigidbody.AddForce (-transform.right * speed * Time.deltaTime, ForceMode.VelocityChange);
		}
	
	}
	
}	

