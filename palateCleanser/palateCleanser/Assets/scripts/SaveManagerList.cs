using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SaveManagerList : MonoBehaviour {
	
	
	public List<GameObject> objectsToSave = new List<GameObject>();
	public List <Vector3> savePositions = new List<Vector3>();
	
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.J))
		{
			SaveGame();
		}
		if (Input.GetKeyDown (KeyCode.K))
		{
			LoadGame();
		}
		
		DetectNewCube();
	}
	
	void SaveGame()
	{
		for (int i = 0; i < objectsToSave.Count; i++)
		{
			savePositions[i] = objectsToSave[i].transform.position;
		}
	}
	
	void LoadGame()
	{
		for (int i = 0; i < savePositions.Count; i++)
		{
		 objectsToSave[i].transform.position = savePositions[i];
		}
	}
	
	void DetectNewCube()
	{
		List <GameObject> possiblyNewCubes = new List<GameObject>(GameObject.FindGameObjectsWithTag("cube"));
		foreach (GameObject possibleCube in possiblyNewCubes)
			if (!objectsToSave.Contains (possibleCube))
		{
			objectsToSave.Add( possibleCube);
			savePositions.Add ( possibleCube.transform.position);
		}		
	}
}
