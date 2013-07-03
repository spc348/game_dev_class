using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class leveldvider2controller : MonoBehaviour {
	
	public AudioClip clip;
	public AudioClip clip2;
	public GUIStyle style;
	int life = 20;
    int hitCount = 0;
	public GameObject levelController;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (life < 1)
		{
		audio.PlayOneShot(clip);
		levelController.SendMessage("DividerDown", SendMessageOptions.DontRequireReceiver);
		Destroy(gameObject, 1f);
		
		}
	}
	
	void BlockDown(){
	life--;	
	audio.PlayOneShot(clip2);
	ChangeColor();
	hitCount++;
	
	}
	

	void ChangeColor()
	{
			if (hitCount > 18)
			hitCount = 0;
		
		Color[] colorsArray = {Color.red,Color.green, Color.blue, Color.yellow, Color.magenta, Color.yellow,
											Color.green, Color.red, Color.grey,Color.red,Color.green, Color.blue, Color.black,
											Color.magenta, Color.yellow, Color.green, Color.red, Color.grey, Color.yellow, 
											Color.green };
		
		MeshRenderer meshRender;
		
		List <GameObject> newBlocks = new List <GameObject>(GameObject.FindGameObjectsWithTag("backboard2"));
		for ( int i = 0; i < newBlocks.Count; i++)
		    {
		            meshRender = newBlocks[i].GetComponent<MeshRenderer>();
			        meshRender.material.color = Color.Lerp(meshRender.material.color,colorsArray[hitCount] , 1f);
			    
		     }
	   }
}
