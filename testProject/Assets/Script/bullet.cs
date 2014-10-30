using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class bullet : MonoBehaviour {

	public float speed = 100;

	// Use this for initialization
	void Start () {
		rigidbody.velocity = transform.forward * speed;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
