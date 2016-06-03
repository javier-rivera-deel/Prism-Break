using UnityEngine;
using System.Collections;

public class PlayScale : MonoBehaviour {

	void OnTriggerEnter(Collider sound)
	{
		if(sound.name == "do")
			sound.audio.Play ();
		if(sound.name == "re")
			sound.audio.Play ();
		if(sound.name == "mi")
			sound.audio.Play ();
		if(sound.name == "fa")
			sound.audio.Play ();
		if(sound.name == "sol")
			sound.audio.Play ();
		if(sound.name == "la")
			sound.audio.Play ();
		if(sound.name == "si")
			sound.audio.Play ();
	}
}
