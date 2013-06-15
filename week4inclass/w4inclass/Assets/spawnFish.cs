using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnFish : MonoBehaviour {
	
		public fishMove blueprint; 
	    public static int fishCount = 200;
	    public List<fishMove> fishList = new List<fishMove>();

	void Start () {
		for ( int i = 0; i < fishCount; i++){
			fishMove newFish = Instantiate (blueprint) as fishMove;
			fishList.Add (newFish);
		}
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown( KeyCode.Space)){
			
		foreach ( fishMove fish	in fishList) {
				fish.SetNewDestination( new Vector3(0f,0f,0f));
		}
	}
	}
	
}
