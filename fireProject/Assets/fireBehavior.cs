using UnityEngine;
using System.Collections;

public class fireBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.Rotate (0,10f,0);
	}
	void OnTriggerEnter (Collider other){
	  if (other.tag == "ship"){
			coinCounter.fireCount--;
			
		Destroy(this.gameObject);	
		}
	}
}
