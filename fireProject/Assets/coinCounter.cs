using UnityEngine;
using System.Collections;

public class coinCounter : MonoBehaviour {

	 public static int coinCount = 0;
	public static int fireCount = 5;
	
	void OnGUI() {
		string coinText = "Coins : " + coinCount + " | Fires: " + fireCount;
        GUI.Box(new Rect(Screen.width-150,20,130,20), coinText);
		if (coinCount == 5 && fireCount == 0){
		GUI.Box (new Rect(0,0,Screen.width,Screen.height), "You Win \n This Time") ;	
		}
    }
}

        