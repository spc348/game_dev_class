using UnityEngine;
using System.Collections;

public class triggerJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		other.attachedRigidbody.AddForce(transform.up * Time.deltaTime, ForceMode.Impulse) ;	
		}
	
	void OnTriggerExit(Collider other){
	
	}
	
}
