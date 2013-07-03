using UnityEngine;
using System.Collections;

public class level2done : MonoBehaviour {
	
	public GUIStyle style;
	public int dividersLeft;
	public bool done;
	public AudioClip clip;

	
	// Use this for initialization
	void Start () {
		dividersLeft = 4;
		done = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (dividersLeft == 0){
			done = true;
				audio.PlayOneShot(clip);
			Application.LoadLevel ("soccer");
		}
	}
	
	void DividerDown()
	{
		dividersLeft--;
	}
	
		void OnGUI()
	{
		if(done)
		{
		GUI.skin.box = style;
		GUI.backgroundColor = Color.yellow;
		GUI.contentColor = Color.white;
		GUI.Box (new Rect(0,0,Screen.width,Screen.height), "You Win \n Nice") ;	
		}
	}
	
}
