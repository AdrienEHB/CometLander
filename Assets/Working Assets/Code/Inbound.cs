using UnityEngine;
using System.Collections;

public class Inbound : MonoBehaviour {

	public float x;
	public float y;
	
	private GameObject[] arrayOfInbounds;
	private Object inbound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate() {
		
		x = Random.Range(-1000, 1000);
		y = Random.Range(-1000, 1000);
		
		arrayOfInbounds = GameObject.FindGameObjectsWithTag("Inbound");
		
		if (arrayOfInbounds.Length != 10) {
			GameObject inbound = GameObject.Instantiate(gameObject, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
		}
		
	}
	
	void OnCollisionEnter2D(Collision2D collide) {
		Debug.Log(collide.gameObject.tag);
		if (collide.gameObject.tag == "Comet") {
			Destroy(gameObject);
		}
	}
}
