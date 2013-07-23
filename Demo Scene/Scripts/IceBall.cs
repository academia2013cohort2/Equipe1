using UnityEngine;
using System.Collections;

public class IceBall : MonoBehaviour {
	public bool isGoingRight;
	public GameObject source;
	public GameObject water;
	
	// Use this for initialization
	void Start () {
		
		source = GameObject.Find("Player");
		water = GameObject.Find("water");
		isGoingRight = source.GetComponent<PlatformerController>().isGoingRight;
		transform.Translate(Vector3.up * 1.0f);
		if (isGoingRight == true){
			transform.Translate(Vector3.right * 1.5f);
			
		}
		else{
			transform.Translate(Vector3.left * 1.5f);
			
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject == water)
		{
			water.renderer.material.shader = Shader.Find ("Specular");
			water.collider.enabled = true;
			
		}
		if (other.gameObject != source)
		{
		source.GetComponent<throwIceball>().exists = false;
		Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (isGoingRight == true)
		{
			
			transform.Translate(Vector3.right * Time.deltaTime * 10.0f);
		}
		else
		{
			
			transform.Translate(Vector3.left * Time.deltaTime * 10.0f);
		}
	}
}
