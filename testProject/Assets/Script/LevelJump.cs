using UnityEngine;
using System.Collections;

public class LevelJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		// asks the program if the 'e' key was pressed
		if(Input.GetKeyDown(KeyCode.E))
		{
			// go to Elise's level if 'e' was pressed
			Application.LoadLevel("Elise");
		}

		if(Input.GetKeyDown(KeyCode.R))
		{
			Application.LoadLevel("Rachel");
		}

		if(Input.GetKeyDown(KeyCode.T))
		{
			Application.LoadLevel("Allie");
		}
	}
}
