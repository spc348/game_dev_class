using UnityEngine;
using System.Collections;

public class triggerDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	  void OnTriggerEnter(Collider other){
		if (other.tag == "ship"){
			Destroy (gameObject,1f);
	}
}
	
	void OnTriggerExit(Collider other){
		
	}
}
