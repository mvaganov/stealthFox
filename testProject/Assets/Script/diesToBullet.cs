using UnityEngine;
using System.Collections;

public class diesToBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		bullet b = col.gameObject.GetComponent<bullet> ();
		if (b != null) {
			renderer.material.color = new Color(
				Random.Range(0,1f),
				Random.Range(0,1f),
				Random.Range(0,1f));
		}
	}
}
