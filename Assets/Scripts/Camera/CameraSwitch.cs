using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {
	public GameObject Sequence01;

	// Update is called once per frame
	void StopCamera () {
		animation.Stop("Sequence01");
	}
}
