using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class level2dividers : MonoBehaviour {
	public float smooth;
	public AudioClip clip;
	public AudioClip clip2;
	public GUIStyle style;
	public int life;
    public int hitCount;
	public GameObject levelController;
	public Vector3 basePosition;
	
	// Use this for initialization
	void Start () {
		basePosition = transform.position;
		life = 20;
		hitCount = 0;
		smooth = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		if (life < 1)
		{
		audio.PlayOneShot(clip);
		levelController.SendMessage("DividerDown", SendMessageOptions.DontRequireReceiver);
	   Destroy (gameObject);
		}
	}
	
	void BlockDown(){
	life--;	
	audio.PlayOneShot(clip2);
	hitCount++;
	StartCoroutine(Shake (50f,1f));
	}
	
	
	IEnumerator Shake( float shakeIntensity, float shakeDuration)
	{
		float t = 1f;
		while ( t > 0f)
		{	
			if( Input.GetKeyDown(KeyCode.M))
				break;
			t-= Time.deltaTime / shakeDuration;	
			transform.position = basePosition 
																	+ ( transform.right * Mathf.Sin (Time.time * shakeIntensity) ) * t
																	+ ( transform.forward * Mathf.Sin (Time.time * shakeIntensity) ) * t
																	+ (transform.up * Mathf.Sin (Time.time * shakeIntensity)) * t;
			yield return 0;	
		}
			transform.position = basePosition;
	 }
	
	
}
