using UnityEngine;
using System.Collections;

public class coinBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (1f,0,0);
	}
	
	void OnTriggerEnter(Collider other){
	if (other.tag == "ship"){
			coinCounter.coinCount ++;
			Destroy (this.gameObject);
	}
}	
}
