using UnityEngine;
using System.Collections;

public class SwitchRotation : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if(other.name == "SwitchBox")
		{
			Debug.Log (other.name);
			other.GetComponent<Animator>().SetBool("SwitchPressed",true);
		}
	}
}
