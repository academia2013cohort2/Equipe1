using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour {
	public bool isGoingRight;
	public GameObject source;
	public GameObject ice;
	
	// Use this for initialization
	void Start () {
		source = GameObject.Find("Player2");
		ice = GameObject.Find("ice");
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
		if (other.gameObject == ice)
		{
			Destroy(ice);
			
		}
		if (other.gameObject != source)
		{
		source.GetComponent<throwFireball>().exists = false;
		Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (isGoingRight == true)
		{	
			transform.Translate(Vector3.right * Time.deltaTime * 10.0f);
			;
		}
		else
		{
			
			transform.Translate(Vector3.left * Time.deltaTime * 10.0f);
		}
	}
}
