using UnityEngine;
using System.Collections;

public class LightStrobe : MonoBehaviour {
	public float intensityStart = 0, intensityEnd = 2;
	public float duration = 3;
	public bool reverseAlso = true;
	float timer;
	float totalIntensityChange;
	bool reversing = false;

	void Start () {
		totalIntensityChange = intensityEnd - intensityStart;
	}
	void Update () {
		if(timer < duration) {
			Light light = GetComponent<Light>();
			if(!reversing) {
				light.intensity = 
					totalIntensityChange * timer / duration+ intensityStart;
			} else {
				light.intensity = 
					totalIntensityChange * (duration-timer) / duration+ intensityStart;
			}
		} else {
			if(reverseAlso) {
				timer = 0;
				reversing = !reversing;
			}
		}
		//timer = timer + Time.deltaTime;
		timer += Time.deltaTime; // compound operator
	}
}
