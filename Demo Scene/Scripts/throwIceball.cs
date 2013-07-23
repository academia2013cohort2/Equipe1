using UnityEngine;
using System.Collections;

public class throwIceball : MonoBehaviour {
	PlatformerController mHasControl;
	public bool hasControl;
	public GameObject iceball;
	public Rigidbody iceballInstance;
	public bool exists;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mHasControl = GetComponent<PlatformerController>();
		hasControl = mHasControl.mHasControl;
	if (Input.GetKeyDown(KeyCode.K) && exists == false && hasControl == true)
		{
			
			iceballInstance = Instantiate(iceball, transform.position, transform.rotation) as Rigidbody;
			exists = true;
		}
	}
	
	
}
