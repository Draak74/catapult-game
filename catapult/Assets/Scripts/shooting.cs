using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

	bool isPressed; 
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		isPressed = Input.GetKey (KeyCode.Mouse0);
		print (isPressed);
	}

	void FixedUpdate() {
		if (isPressed == true) {
			Instantiate (bulletPrefab,transform.position,transform.rotation);

		}
	}
	private void OnCollisionEnter(Collision collidedObject){
		print (collidedObject.gameObject.name);
		if(collidedObject.gameObject.tag == "Player") {
			print ("PlayerHit");
			Destroy (collidedObject.gameObject);
		}
}
