using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SaveManager3 : MonoBehaviour {
	
	public Dictionary<GameObject,Vector3> objectPositions = new Dictionary<GameObject, Vector3>();
	// key is object and value is the vector
	
	
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.O))
		{
				Debug.Log("saved");
			SaveGame();
		}
		if (Input.GetKeyDown (KeyCode.P))
		{
			Debug.Log("loaded");
			LoadGame();
		}
		
		DetectNewCube();
	}
	
	void SaveGame()
	{
		foreach (KeyValuePair<GameObject, Vector3> keypair in objectPositions)
		{
			objectPositions[keypair.Key] = keypair.Key.transform.position;
		}
	}
	
	void LoadGame()
	{
		foreach (KeyValuePair<GameObject, Vector3> keypair in objectPositions)
		{
			keypair.Key.transform.position = objectPositions[keypair.Key];
		}
	}
	
	void DetectNewCube()
	{
		List <GameObject> possiblyNewCubes = new List<GameObject>(GameObject.FindGameObjectsWithTag("cube"));
		foreach (GameObject possibleCube in possiblyNewCubes)
			if (objectPositions.ContainsKey (possibleCube))
		{
			objectPositions.Add (possibleCube,possibleCube.transform.position);
		}		
	}
}
