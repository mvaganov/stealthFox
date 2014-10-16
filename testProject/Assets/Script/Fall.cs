using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {

	Vector3 startPosition;
	public float minimumHeight = -10;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < minimumHeight)
		{
			transform.position= startPosition;
		}
	}
}