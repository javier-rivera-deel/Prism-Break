using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {

	GameObject Switch;
	Animator anim;

	void Awake()
	{
		Switch = GameObject.Find("Switch");
		anim = Switch.GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.name == "SwitchRotacion")
			anim.SetBool ("SwitchPressed",true);
	}


}
