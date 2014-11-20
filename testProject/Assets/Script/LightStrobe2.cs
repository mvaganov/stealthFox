using UnityEngine;
using System.Collections;

public class LightStrobe2 : MonoBehaviour {
	public float intensityStart = 0, intensityEnd = 2;
	public float duration = 0.01f;
	public float offDuration;
	public float reverseDuration = 0.01f;
	public bool reverseAlso = true;
	float timer;
	float totalIntensityChange;
	bool reversing = false;
	bool doneReversing = false;
	
	void Start () {
		totalIntensityChange = intensityEnd - intensityStart;
	}
	void Update () {
		if(timer < duration) {
			Light light = GetComponent<Light>();
			if(!reversing && doneReversing == false) {
				light.intensity = 
					totalIntensityChange * timer / duration+ intensityStart;
			} 
//			else if (!reversing  && doneReversing == false){
//				light.intensity = 
//					totalIntensityChange * timer / reverseDuration+ intensityStart;
//			} else if (reversing && doneReversing == true){
//			light.intensity = 
//				totalIntensityChange * timer / offDuration+ intensityStart;
//			} 
		else {
				light.intensity = 
					totalIntensityChange * (reverseDuration-timer) / reverseDuration+ intensityStart;
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
