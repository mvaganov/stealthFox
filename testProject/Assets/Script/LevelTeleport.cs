using UnityEngine;
using System.Collections;

public class LevelTeleport : MonoBehaviour {

	public string levelName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		CharacterController cc = other.gameObject.GetComponent<CharacterController> ();
		if(cc != null) {
			Application.LoadLevel(levelName);
		}
	}
}
