using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class levelDividerController : MonoBehaviour {
	
	public AudioClip clip;
	public GameObject controller;
	public bool levelDone = true; 
	public Camera camera;
	public GameObject ball;
	public GameObject player;
	public int life = 9;
	Vector3 level2ballPOS = new Vector3(.5f,1f,20f);
	Vector3 level2playerPOS = new Vector3(.5f,1f,19f);
	public int hitCount = 0;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (life < 1 && levelDone)
		{
		ball.transform.position = level2ballPOS;
		player.transform.position = level2playerPOS;
		camera.transform.Translate(new Vector3 (0f,1.5f,23f));
		renderer.enabled = false;
		levelDone = false;
		controller.SendMessage("DividerDown", SendMessageOptions.DontRequireReceiver);
		}
		
	}
	
	void BlockDown()
	{
		life--;	
    	audio.PlayOneShot(clip);
		ChangeColor();
		hitCount++;
	}
	
	void ChangeColor()
	{
		if (hitCount > 18)
			hitCount = 0;
		
		Color[] colorsArray = { Color.red,Color.green, Color.blue, Color.black, Color.magenta, Color.yellow,
											Color.green, Color.red, Color.blue,Color.red,Color.green, Color.blue, Color.yellow,
											Color.magenta, Color.yellow, Color.green, Color.red, Color.grey, Color.yellow, 
											Color.red };
		
		MeshRenderer meshRender;
		
		List <GameObject> newBlocks = new List <GameObject>(GameObject.FindGameObjectsWithTag("backboard1"));
		for ( int i = 0; i < newBlocks.Count; i++)
		   {
		            meshRender = newBlocks[i].GetComponent<MeshRenderer>();
			        meshRender.material.color = Color.Lerp(meshRender.material.color,colorsArray[hitCount] , 1f);	
		}
	   }
	
	
	
}
