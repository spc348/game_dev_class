using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SaveManager : MonoBehaviour {
	
	public Transform cube1;
	public Transform cube2;
	public Transform cube3;
	
	
	public Vector3 cube1SavePos;
	public Vector3 cube2SavePos;
	public Vector3 cube3SavePos;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.S))
		{
			SaveGame();
		}
		if (Input.GetKeyDown (KeyCode.L))
		{
			LoadGame();
		}
	}
	
	void SaveGame()
	{
		Debug.Log ("saved");
	 cube1SavePos = cube1.position;
	 cube2SavePos = cube2.position;
     cube3SavePos = cube3.position;
	}
	
	void LoadGame()
	{
		Debug.Log ("loaded");
	cube1.position = cube1SavePos;
	cube2.position = cube2SavePos;
	cube3.position = cube3SavePos;
	}
}
