using UnityEngine;
using System.Collections;

public class backboardtriggersL2 : MonoBehaviour {
	
	public GameObject levelDivider;
	public bool dead;
	public float smooth;
	Color colorChange;
	public int waitTime;
	
	void Start()
	{
		dead = false;	
		smooth = 2f;
		gameObject.AddComponent<Light>();
		light.intensity = 8f;
		waitTime = 5;
	}
	void Update()
	{	
	 	
	 
		if(!levelDivider)
		{
		Destroy(gameObject);	
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Ball" && !dead)
		{
		StartCoroutine(ChangeColor ());
		levelDivider.SendMessage("BlockDown", SendMessageOptions.RequireReceiver);
		dead = true;
		Destroy(this.gameObject);	
		}
	}
	
	IEnumerator ChangeColor()
	{
			
		    
			if ( gameObject.light.color == Color.white)
			colorChange = Color.red;
			
			if (gameObject.light.color == Color.red)
			colorChange = Color.white;
		
		gameObject.light.color = Color.Lerp (gameObject.light.color, colorChange, smooth * Time.deltaTime);	
		
		yield return new WaitForSeconds(waitTime);
	}
}
