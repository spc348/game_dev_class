using UnityEngine;
using System.Collections;

public class fishMove : MonoBehaviour {
	
	 Vector3 destination;

	void Start () {
	SetNewDestination();
	}
	
	void Update(){	
	}
	
	void FixedUpdate () {
		rigidbody.AddForce ((destination - transform.position).normalized, ForceMode.VelocityChange);
		if(Vector3.Distance (destination, transform.position) < 10f){
		SetNewDestination();	
		}
	}
	
	public void SetNewDestination(){
		SetNewDestination(20f);	
	}
	
	public void SetNewDestination(float range){
		SetNewDestination(Random.insideUnitSphere * range );	
	}
	
	public void SetNewDestination( Vector3 newDestination ){
		destination = newDestination;
	}
}
