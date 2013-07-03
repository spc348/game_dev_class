using UnityEngine;
using System.Collections;

public class PositionShooter : MonoBehaviour {
	
	public Vector3 target;
	public float speed = 5f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		float h = Input.mousePosition.x;
		float v = Input.mousePosition.y;
		
		transform.position = new Vector3 ( 10f , v, h );
	}
}
