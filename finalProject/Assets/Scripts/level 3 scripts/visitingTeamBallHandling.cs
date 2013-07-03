using UnityEngine;
using System.Collections;

public class visitingTeamBallHandling : MonoBehaviour {
	
	public Rigidbody body;
	public float visitorMovement = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate()
	{
		
	}
	
	void OnTriggerCollider(Collider other)
	{
		if (other.tag=="Ball")
		{
			body.rigidbody.AddForce (other.transform.position * visitorMovement);	
		}
		if (other.tag == "Player")
		{
			
			body.rigidbody.AddForce(NavigateBlock (other.transform.position) * visitorMovement);
		}
	}
	  Vector3 NavigateBlock(Vector3 playerPosition)
			{
				Vector3 blockPos = new Vector3 (playerPosition.x,playerPosition.y, (playerPosition.z - 10f));
				
				return blockPos;
				
			}
}
