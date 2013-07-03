using UnityEngine;
using System.Collections;

public class raquetTrigger : MonoBehaviour {
	
	public GameObject swingArm;
	public AudioClip tennisHit;
	public Camera camera;
	public float swingSpeed = 4f;
	public GameObject ball;
	Vector3 newTrajectory;
	
	void OnTriggerEnter(Collider other)
	{
		if ( other.tag == "Ball")
		{	
		Inverter();
		NewTrajectory(newTrajectory);
		audio.PlayOneShot(tennisHit);
		swingArm.GetComponent<swingController>().animation.CrossFade("swing");
		}
	}

	Vector3 Inverter ()
		{
		RaycastHit hit = new RaycastHit();
		
		Ray ray  = camera.ScreenPointToRay(Input.mousePosition);
		
		if ( Physics.Raycast (ray, out hit, 10000f) )
		{
		   if ( hit.collider.tag != "Ball")
			newTrajectory = hit.point;
		}
		
		return newTrajectory;
		}
	
	void NewTrajectory (Vector3 direction)
	{
		Vector3 startPos = ball.transform.position;
		Vector3 swingVector = direction - startPos;
		
		ball.rigidbody.AddForce (swingVector * swingSpeed, ForceMode.VelocityChange) ;
	}
	
	
}
