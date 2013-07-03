using UnityEngine;
using System.Collections;

public class swingController : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	if (Input.GetMouseButtonDown(0))
		{
			animation.CrossFade("swing");
		}	
	}
}
