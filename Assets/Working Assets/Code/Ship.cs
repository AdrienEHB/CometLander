using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	public float thrustpower = 20;
	public float thrustrotation = 3;
	public Camera cam;
	public float camSensitivity = 0.5f;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Update(){
		cam.orthographicSize = Mathf.Lerp(cam.orthographicSize,15 + rigidbody2D.velocity.magnitude * camSensitivity,Time.deltaTime * 2);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey("left")){
			this.rigidbody2D.AddRelativeForce(new Vector2(0, thrustpower));
			this.rigidbody2D.AddTorque(-thrustrotation);
			
		}
		if(Input.GetKey("right")){
			this.rigidbody2D.AddRelativeForce(new Vector2(0, thrustpower));
			this.rigidbody2D.AddTorque(thrustrotation);
		}
		
		
		
	}
}
