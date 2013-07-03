using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public float difficulty = 2f;
	
	// Update is called once per frame
	void Update () {
	transform.Rotate (1f * difficulty , 0f , 0f);
	}
}
