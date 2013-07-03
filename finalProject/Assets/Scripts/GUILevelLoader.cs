using UnityEngine;
using System.Collections;

public class GUILevelLoader : MonoBehaviour {
	
	public Rect windowRect = new Rect(20, 20, 200, 100);
	public bool turnOff = true;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {		
	}
	
	void OnGUI()
	{
		if(turnOff )
		windowRect = GUI.Window(0, windowRect, DoMyWindow, 
				(Application.loadedLevelName == "tennis") ? "tennis level" : "space invaders level ");
	}
	
	void DoMyWindow(int windowID) {
        if (GUI.Button(new Rect(	((Application.loadedLevelName == "tennis") ? 10 : 50),
																				20, 100, 20), "Play"))
            turnOff = false;
	}
	
}