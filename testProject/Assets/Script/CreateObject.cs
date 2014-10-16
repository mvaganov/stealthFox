using UnityEngine;
using System.Collections;

public class CreateObject : MonoBehaviour {

	public GameObject whatToCreate;
	public KeyCode whichKeyCreatesIt = KeyCode.Alpha1;
	public float distanceInFront = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(whichKeyCreatesIt))
		{
			// create the thing I want right in front of me
			Instantiate(whatToCreate, 
			            transform.position + transform.forward * distanceInFront,
			            // facing the same direction as me.
			            transform.rotation);
		}
	}
}
