using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class Bullet : MonoBehaviour {

	public float speed = 100;
	public float damage = 1;
	// Use this for initialization
	void Start () {
		rigidbody.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
