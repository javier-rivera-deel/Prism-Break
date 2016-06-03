using UnityEngine;
using System.Collections;

public class LoadTutorial : MonoBehaviour {
	public string Escena;

	public void NextLevel (string Escena) {
		Application.LoadLevel (Escena);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.name == "SwitchRotacion")
			NextLevel ("PiramidFinal");

	}
}

