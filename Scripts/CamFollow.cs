using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///------------------------------------------------------------------------------
///   
///   Author:          Omar Khawaja                     
///   Description:     Camera script to follow planets etc. 
///                    
///------------------------------------------------------------------------------
public class CamFollow : MonoBehaviour
{
	// Follow this body. 
	public Transform followThis;

	public float lagSpeed = 10f;
	public Vector3 offset;

	// FixedUpdate is better for Physics simulations. 
	void FixedUpdate()
	{
		// Set camera's position to the body's position + some offset amount. 
		Vector3 thePosition = followThis.position + offset;

		// Moving move the camera gradually between the camera's position and the position of the body. 
		Vector3 lagPosition = Vector3.Lerp(transform.position, thePosition, lagSpeed*Time.fixedDeltaTime);
		// Set. 
		transform.position = lagPosition;

		// Rotates the camera's transform so the forward vector points at body's current position.
		transform.LookAt(followThis);
	}

}
