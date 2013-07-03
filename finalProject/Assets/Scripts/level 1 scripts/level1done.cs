using UnityEngine;
using System.Collections;

public class level1done : MonoBehaviour {
	public GUIStyle style;
	public int hitCount;
	public bool done = false;
	public AudioClip clip;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (hitCount == 2){
			done = true;
				audio.PlayOneShot(clip);
				Application.LoadLevel ("level 2 take two");
		}
	}
	
	void DividerDown()
	{
		hitCount++;
		
	}
	
		void OnGUI()
	{
		if(done)
		{
		GUI.skin.box = style;
		GUI.backgroundColor = Color.yellow;
		GUI.contentColor = Color.black;
		GUI.Box (new Rect(0,0,Screen.width,Screen.height), "You Win \n Nice Upgrade") ;	
		}
	}
	

	
		
		
	
}	