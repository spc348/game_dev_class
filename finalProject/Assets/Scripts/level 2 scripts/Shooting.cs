using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
	public AudioClip clip;
	public Rigidbody projectile;
	public Transform shotPos;
	public float shotForce = 1000f;
	public Vector3 basePosition;
	public Vector3 baseGunPosition;
	public GameObject gun;
	
	void Start() 
	{
		basePosition = transform.localPosition;
		baseGunPosition = gun.transform.localPosition;
	}
	
	void Update () {
	if (Input.GetButtonUp("Fire1"))
		{
		Rigidbody shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as Rigidbody;
            shot.AddForce(shotPos.forward * shotForce);
			audio.PlayOneShot(clip);
			StartCoroutine(FiringShake());
		}
		
		if(Input.GetMouseButton(1))
		{
			camera.fieldOfView = 24; 
		}
		else
			camera.fieldOfView = 48;
	}
	
	IEnumerator FiringShake()
	{
		float t = 1f;
		while ( t > 0f)
		{	
			if( Input.GetKeyDown(KeyCode.L))
				break;
			t-= Time.deltaTime;	
			gun.transform.localPosition = baseGunPosition + (transform.up * Mathf.Sin (Time.time * 1f)) * t
																	+	(transform.right * Mathf.Sin (Time.time * 1f)) * t;
			yield return 0;	
		}
		gun.transform.localPosition = baseGunPosition;
	}
	
	
	

}

