using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {

	Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -10) 
				{
				transform.position = startPosition;
				}
	}
}
