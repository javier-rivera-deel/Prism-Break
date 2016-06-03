using UnityEngine;
using System.Collections;
using System.Linq;
using System;

public class LightDance1 : MonoBehaviour {
	/*
	//array of game objects 
	public static GameObject[] totem;

	//array of the musical sequence
	public static int[] unordored_musical_sequence;

	//current totem/note 
	public static int current_step = 0;

	//allows the sequence to be called after time_to_lit_up
	public static bool sequence_available = true;
	public static float time_to_lit_up = 1.0;

	//determines the max amount of steps in the sequence
	public static int light_sequence_steps = 7;
	
	void Awake()
	{
		//Creates an array with a random sequence of numbers from 0 to 7
		NewSequence ();

		//Creates an array of totems game objects, keeping track of references
		totem = GameObject.FindGameObjectsWithTag("MusicalNote");
	}

	void Start () 
	{

	}

	IEnumerator LightSequence()
	{
		//Debug purposes
		//print ("light "+ count +  "on");

		//Turns on the light on mesh component of game object, ditacted by unordered_musical_sequence
		totem[unordored_musical_sequence[current_step]].GetComponent<MeshRenderer>().enabled = true;

		//plays musical note of game object
		totem[unordored_musical_sequence[current_step]].audio.Play();
		
		//avoids calling the function after 1 second
		sequence_available = false;
		yield return new WaitForSeconds (time_to_lit_up);

		//coroutine continues after 1 second, turns off the light 
		totem[unordored_musical_sequence[current_step]].GetComponent<MeshRenderer>().enabled = false;

		//moves forward to next totem
		current_step++;

		//allows LightSequence to be called again
		sequence_available = true;
	}
	
	void Update ()
	{
		if(sequence_available && current_step < light_sequence_steps)
		{
			StartCoroutine (LightSequence ());
		}
	}
	
	//Creates an array with a random sequence of numbers from 1 -> 7
	public static void NewSequence()
	{
		System.Random ran = new System.Random();
		unordored_musical_sequence = Enumerable.Range(0, 7).OrderBy(x => ran.Next()).ToArray();
	}		
	*/
}
	
	

