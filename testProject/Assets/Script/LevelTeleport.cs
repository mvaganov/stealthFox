using UnityEngine;
using System.Collections;

public class LevelTeleport : MonoBehaviour {

	public string levelName;

	// Use this for initialization
	void Start () {
		Collider collider = GetComponent<Collider> ();
		if(!collider.isTrigger) {
			Debug.Log(collider+" needs to be set as a trigger!");
			collider.isTrigger = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void TeleportIfCharacterController(GameObject other) {
		CharacterController cc = other.GetComponent<CharacterController> ();
		if(cc != null) {
			Application.LoadLevel(levelName);
		}
	}

	void OnTriggerEnter(Collider other) {
		TeleportIfCharacterController (other.gameObject);
	}
}
