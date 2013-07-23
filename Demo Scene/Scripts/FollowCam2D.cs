using UnityEngine;
using System.Collections;

public class FollowCam2D : MonoBehaviour
{
	public Transform target;
	public GameObject target2;
	public GameObject player1;
	public GameObject player2;
	
	public float distance = 10.0f;
	public float extraHeight = 2.0f;

	float origDist;

	void Start () 
	{
		origDist = distance;
	}

	void FixedUpdate () 
	{
		if (target)
		{
			if (Input.GetKey(KeyCode.LeftControl))
				distance = origDist * 5;
			else
				distance = origDist;

			Vector3 targetPos = target.position + Vector3.up * extraHeight;
			targetPos.z = -distance;
			transform.position -= (transform.position - targetPos) * 0.25f;
			
		}
		if (Input.GetKeyDown(KeyCode.Z) && target2 == player1)
			{
			
				target2 = player2;
			
				target = target2.transform;	
				
				
			}
			else if (Input.GetKeyDown(KeyCode.Z) && target2 == player2)
			{
				target2 = player1;
			
				target = target2.transform;	
			
			}
		
		
		
	}

	public void SetTarget(Transform inTarget)
	{
		target = inTarget;
	}
}

