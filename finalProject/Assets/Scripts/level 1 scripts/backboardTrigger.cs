using UnityEngine;
using System.Collections;

public class backboardTrigger : MonoBehaviour {
	
	public GameObject leveldivider;
	public bool death  = true;
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Ball" && death)
		{
		leveldivider.SendMessage("BlockDown",SendMessageOptions.DontRequireReceiver);
		Destroy(this.gameObject);	
		death = false;
		}
	}
}
