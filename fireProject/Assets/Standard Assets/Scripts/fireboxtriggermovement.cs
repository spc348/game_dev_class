using UnityEngine;
using System.Collections;

public class fireboxtriggermovement : MonoBehaviour {
	private Vector3 newPosition;
	void Start()  {
	
	}
	void FixedUpdate(){
	transform.Rotate(0, 15f * Time.deltaTime,0);	
	Vector3	newPosition =  new Vector3(Random.Range(-15f,15f),Random.Range(-15f,15f), Random.Range(-15f,15f));
	transform.position = Vector3.Lerp (transform.position, newPosition, 2f *Time.deltaTime);
	}

  
}