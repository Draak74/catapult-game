using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		transform.position += transform.forward;
	}

	private void OnCollisionEnter(Collision collidedObject){
		print (collidedObject.gameObject.name);
		if(collidedObject.gameObject.tag == "Enemy") {
			print ("EnemyHit");
			Destroy (collidedObject.gameObject);
		}
	}
}
