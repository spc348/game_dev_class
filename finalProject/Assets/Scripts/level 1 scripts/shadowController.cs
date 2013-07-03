using UnityEngine;
using System.Collections;

public class shadowController : MonoBehaviour {
	
	public float lockPos = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	transform.rotation = Quaternion.Euler (90f, lockPos, lockPos);
	}
}
