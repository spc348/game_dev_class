using UnityEngine;
using System.Collections;

public class Ufo : MonoBehaviour {
	
	public float moveSpeed = 3f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
		if(Input.GetKey (KeyCode.RightArrow)){
	transform.Translate( moveSpeed * Time.deltaTime ,0f, 0f);
	}
	
	if(Input.GetKey (KeyCode.LeftArrow)){
	transform.Translate( -moveSpeed * Time.deltaTime ,0f, 0f);
		}
	
	if(Input.GetKey (KeyCode.UpArrow)){
	transform.Translate( 0f, 0f, moveSpeed * Time.deltaTime);
		}
		
		if(Input.GetKey (KeyCode.DownArrow)){
	transform.Translate( 0f, 0f, -moveSpeed * Time.deltaTime );
		}
	
		if(Input.GetKey (KeyCode.J)){
	transform.Translate( 0f, 2 * moveSpeed * Time.deltaTime, 0f );
		}
		
		if(Input.GetKey (KeyCode.N)){
	transform.Translate( 0f, 2 * -moveSpeed * Time.deltaTime, 0f );
		}
	}
}
