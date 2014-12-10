using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	public float thrustpower = 20;
	public float thrustrotation = 3;
	public Transform gravityCenter;
	public float gravity = 1;
	public Camera cam;
	public float camSensitivity = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	
	void Update(){
		//cam.orthographicSize = 15 + rigidbody2D.velocity.magnitude * camSensitivity;
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
		
		/*if (transform.position.x > gravityCenter.position.x){
			rigidbody2D.AddForce(new Vector2(-gravity,0));
		} else {
			rigidbody2D.AddForce(new Vector2(gravity,0));
		}
		
   		if (transform.position.y > gravityCenter.position.y){
			rigidbody2D.AddForce(new Vector2(0,-gravity));
		} else {
			rigidbody2D.AddForce(new Vector2(0,gravity));
   		}*/
		
		Vector2 gravityForce = transform.position - gravityCenter.position;
		rigidbody2D.AddForce(-gravityForce * gravity);
		
	}
}
