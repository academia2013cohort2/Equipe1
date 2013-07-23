using UnityEngine;
using System.Collections;

public class throwFireball : MonoBehaviour {
	public PlatformerController mHasControl;
	public bool hasControl;
	public GameObject fireball;
	public Rigidbody fireballInstance;
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
			
			fireballInstance = Instantiate(fireball, transform.position, transform.rotation) as Rigidbody;
			exists = true;
		}
	}
	
	
}
