using UnityEngine;
using System.Collections;

public class PlanetGravity : MonoBehaviour {

	public Transform gravityCenter;
	public float gravity = 1;

	
	void FixedUpdate() {
		Vector2 gravityForce = transform.position - gravityCenter.position;
		rigidbody2D.AddForce(-gravityForce * gravity);
		
	}
}
