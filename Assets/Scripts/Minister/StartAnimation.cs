using UnityEngine;
using System.Collections;

public class StartAnimation : MonoBehaviour {
	public bool s1;
	public bool s2;
	public bool s3;
	public bool s4;
	GameObject Door;

	void OnTriggerEnter(Collider other)
	{
		GameObject passage1 = GameObject.Find("passage1");
		GameObject passage2 = GameObject.Find("passage2");
		GameObject passage3 = GameObject.Find("passage3");
		GameObject passage4 = GameObject.Find("passage4");
		GameObject tower = GameObject.Find("tower");
		Door = GameObject.Find ("SwitchPass");

		if(other.transform.tag == "Enemy")
			Application.LoadLevel ("BreakAgain");

		if(other.transform.name == "Cube")
		{
			tower.GetComponent<Animator>().SetBool("CanOpen",true);
			tower.GetComponent<BoxCollider>().enabled = false;
			other.audio.Play();

		}
		if(other.transform.name == "NextLevel")
		{
			Application.LoadLevel ("Minister");
		}
		if(other.transform.name == "Finish")
		{
			Application.LoadLevel ("ImpossibleArch");
		}




		if(other.transform.name == "s1")
		{
			passage1.GetComponent<Animator> ().SetBool ("Switch1", true);
			passage1.GetComponent<Animator> ().SetBool ("Wrong1", false);
			other.audio.Play ();
			s1 = true;
			//other.renderer.material.color = myColor;
		}
		if(s1 == true && s2 == false && s3 == false && s4 == false && (other.transform.name == "s2" || other.transform.name == "s3" || other.transform.name == "s5"))
		{
			passage1.GetComponent<Animator> ().SetBool ("Switch1", false);
			passage1.GetComponent<Animator> ().SetBool ("Wrong1", true);
			passage2.GetComponent<Animator> ().SetBool ("Switch2", false);
			passage2.GetComponent<Animator> ().SetBool ("Wrong2", true);
			passage3.GetComponent<Animator> ().SetBool ("Switch3", false);
			passage3.GetComponent<Animator> ().SetBool ("Wrong3", true);
			s1 = false;
			s2 = false;
			s3 = false;	
			other.audio.Play();
			Debug.Log ("regresion 1");
		}

		if(other.transform.name == "s4" && s1 == true)
		{
			passage2.GetComponent<Animator> ().SetBool ("Switch2", true);
			passage2.GetComponent<Animator> ().SetBool ("Wrong2", false);
			other.audio.Play ();
			s2 = true;	
		}

		if(s1 == true && s2 == true && s3 == false && s4 == false && (other.transform.name == "s3" || other.transform.name == "s5"))
		{
			passage1.GetComponent<Animator> ().SetBool ("Switch1", false);
			passage1.GetComponent<Animator> ().SetBool ("Wrong1", true);
			passage2.GetComponent<Animator> ().SetBool ("Switch2", false);
			passage2.GetComponent<Animator> ().SetBool ("Wrong2", true);
			passage3.GetComponent<Animator> ().SetBool ("Switch3", false);
			passage3.GetComponent<Animator> ().SetBool ("Wrong3", true);
			s2 = false;
			s3 = false;	
			s1 = false;
			Debug.Log ("regresion 2");
			other.audio.Play();
		}



		if(other.transform.name == "s2" && s1 == true && s2 == true)
		{
			passage3.GetComponent<Animator> ().SetBool ("Switch3", true);
			passage3.GetComponent<Animator> ().SetBool ("Wrong3", false);
			other.audio.Play ();
			s3 = true;	
		}

		if(s1 == true && s2 == true && s3 == true && s4 == false && other.transform.name == "s3")
		{
			passage1.GetComponent<Animator> ().SetBool ("Switch1", false);
			passage1.GetComponent<Animator> ().SetBool ("Wrong1", true);
			passage2.GetComponent<Animator> ().SetBool ("Switch2", false);
			passage2.GetComponent<Animator> ().SetBool ("Wrong2", true);
			passage3.GetComponent<Animator> ().SetBool ("Switch3", false);
			passage3.GetComponent<Animator> ().SetBool ("Wrong3", true);
			s3 = false;	
			s2 = false;
			s1 = false;
			other.audio.Play();
			Debug.Log ("regresion 3");
		}


		if(other.transform.name == "s5" && s1 == true && s2 == true && s3 == true)
		{
			passage4.GetComponent<Animator> ().SetBool ("Switch4", true);
			passage4.GetComponent<Animator> ().SetBool ("Wrong4", false);
			other.audio.Play ();
			s4 = true;	
			Door.GetComponent<BoxCollider>().enabled = false;
		}
	}
}