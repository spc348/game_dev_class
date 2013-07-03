using UnityEngine;
using System.Collections;

public class MouseLooking : MonoBehaviour {
	public float mouseSensitivity = 5f;
	public float rotY;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rotY = Mathf.Clamp (rotY + Input.GetAxis ("Mouse Y"),-90,90);
	    if (Mathf.Abs (Input.GetAxis ("Mouse Y")) > 0.1){
			transform.localRotation = Quaternion.Euler(rotY,0f,0f);
		}
	}
}
