using UnityEngine;
using System.Collections;

/// <summary>
/// For creating AudioSources in temporary objects at a given transform.
/// </summary>
public class PlaySound : MonoBehaviour
{
	public AudioClip sound;
	public string buttonPress;
	public bool loop = false;
	bool played = false;
	
	void Start()
	{
		if (buttonPress == null || buttonPress.Length == 0)
		{
			Play(sound, transform, loop);
		}
	}
	
	void Update()
	{
		if (buttonPress != null && buttonPress.Length > 0
		&& Input.GetButtonDown(buttonPress) && !loop || !played)
		{
			Play(sound, transform, loop);
			played = true;
		}
	}
	
	public static AudioSource Play(AudioClip ac, Transform emitter, bool loop)
	{
		if (ac == null)
		{
			print ("can't play sound!");
			return null;
		}
		GameObject go = new GameObject("sound: " + ac.name);
		AudioSource asrc = go.AddComponent<AudioSource>();
		asrc.loop = loop;
		asrc.clip = ac;
		asrc.Play();
		if(!loop) {
			Destroy(go, ac.length);
		}
		if (emitter != null)
		{
			go.transform.position = emitter.transform.position;
			go.transform.parent = emitter.transform.parent;
		}
		return asrc;
	}
}