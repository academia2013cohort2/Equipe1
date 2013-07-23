using UnityEngine;
using System.Collections;

public class AppearPlatform : MonoBehaviour {

	public GameObject platform;
	
	void OnTriggerEnter(Collider other)
	{
		PlatformerPhysics physics = other.gameObject.GetComponent<PlatformerPhysics>();
		if (physics)
		{
			platform.renderer.material.shader = Shader.Find ("Specular");
			platform.collider.enabled = true;
			
			Destroy(gameObject);
		}
	}
}
