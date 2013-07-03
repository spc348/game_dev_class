using UnityEngine;
using System.Collections;

public class LockingandPausing : MonoBehaviour {

	void Update(){
	
	if (Input.GetKeyDown(KeyCode.Escape))
		{
			Debug.Break(); 
		}

	if(Input.GetKeyDown(KeyCode.L))
	{
		if (Screen.lockCursor == false)
			Screen.lockCursor = true;
	}
		if(Input.GetKeyDown(KeyCode.K))
	{
		if (Screen.lockCursor == true)
			Screen.lockCursor = false;
	}
}	
}
