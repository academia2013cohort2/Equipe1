using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public GameObject player1;
	void OnTriggerEnter(Collider other)
	{
		
		
		if (player1.GetComponent<PlatformerPhysics>().mSprinting == true)
		{
			Destroy(gameObject);
			
		}
	}
}
