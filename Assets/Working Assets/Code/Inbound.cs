using UnityEngine;
using System.Collections;

public class Inbound : MonoBehaviour {

	private float x;
	private float y;
	
	private GameObject[] arrayOfInbounds;
	private Object inbound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate() {
		
		x = Random.Range(Random.Range(-1000, -200), Random.Range(200, 1000));
		y = Random.Range(Random.Range(-1000, -200), Random.Range(200, 1000));
		
		arrayOfInbounds = GameObject.FindGameObjectsWithTag("Inbound");
		
		if (arrayOfInbounds.Length != 10) {
			GameObject.Instantiate(gameObject, new Vector3(x, y, 0), Quaternion.identity);
		}
		
		foreach (GameObject thisInbound in arrayOfInbounds) {
			thisInbound.rigidbody2D.velocity = new Vector2(Mathf.Clamp(thisInbound.rigidbody2D.velocity.x,-10,10), Mathf.Clamp(thisInbound.rigidbody2D.velocity.y,-10,10));
		} 
		
	}
	
	void OnCollisionEnter2D(Collision2D collide) {
		Debug.Log(collide.gameObject.tag);
		if (collide.gameObject.tag == "Comet") {
			Destroy(gameObject);
		}
	}
}
