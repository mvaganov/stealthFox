using UnityEngine;
using System.Collections;

public class HealthAndDeath : MonoBehaviour {

	public float maxHealth = 10;
	public float currentHealth = 10;
	// Use this for initialization
	void Start () {
	}
	void OnCollisionEnter(Collision col) {
		Bullet b = col.gameObject.GetComponent<Bullet> ();
		if (b != null) {
			currentHealth = currentHealth - b.damage;
		}
	}
	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0){
			Destroy(this.gameObject);
		}
	}
}
