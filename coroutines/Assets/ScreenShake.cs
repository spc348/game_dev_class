using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {
	public Vector3 basePosition;
	// Use this for initialization
	void Start () {
	 basePosition = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown(KeyCode.K))
			StartCoroutine(Shake (50f, 1f) );
	}
	
	IEnumerator Shake( float shakeIntensity, float shakeDuration)
	{
		float t = 1f;
		while ( t > 0f)
		{	
			if( Input.GetKeyDown(KeyCode.L))
				break;
			t-= Time.deltaTime / shakeDuration;	
			transform.localPosition = basePosition 
																	+ ( transform.right * Mathf.Sin (Time.time * shakeIntensity) ) * t
																	+ (transform.up * Mathf.Sin (Time.time * shakeIntensity)) * t;
			yield return 0;	
		}
			transform.localPosition = basePosition;
	 }
}
