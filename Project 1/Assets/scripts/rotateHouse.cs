using UnityEngine;
using System.Collections;

public class rotateHouse : MonoBehaviour {
	
	public float rotateSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
	}
}
