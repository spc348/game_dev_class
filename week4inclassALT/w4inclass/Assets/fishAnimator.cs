using UnityEngine;
using System.Collections;

public class fishAnimator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.E)){
		animation.CrossFade("fishIdle");	
		}
		
		if (Input.GetKeyDown(KeyCode.R)){
		animation.CrossFade("fishDance");	
		}
	}
}
