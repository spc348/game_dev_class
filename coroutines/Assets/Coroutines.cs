using UnityEngine;
using System.Collections;

public class Coroutines : MonoBehaviour {

	// Use this for initialization
	void Start () {
	StartCoroutine( AttractMode() );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	IEnumerator AttractMode()
	{
		while (!Input.GetKey ( KeyCode.Space))
		{
			GetComponent<GUIText>().text = "Space Bar Pressed";
			yield return 0;
		}
		
		GetComponent<GUIText>().text = "Welcome to bioshock yay";
			yield return new WaitForSeconds(2f);
	}
}
