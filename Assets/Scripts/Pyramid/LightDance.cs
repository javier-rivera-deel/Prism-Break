using UnityEngine;
using System.Collections;
using System.Linq;
using System;


public class LightDance : MonoBehaviour {


	public static float timer;
	public static GameObject a,b,c,d,e,f,g;
	public static MeshRenderer meshA,meshB,meshC,meshD,meshE,meshF,meshG;
	public static float Switch;
	public static bool On = false;
	public static int acum = 0;
	public static int[] randomArray;
	public static float timeToTurnOff = 1f;
	public static float timeToTurnOn = 1f;

	void Awake()
	{
		//Crea la nueva secuencia de lightdance
		NewSequence ();

		//inicializa las referencias
		a = GameObject.Find ("a");
		b = GameObject.Find ("b");
		c = GameObject.Find ("c");
		d = GameObject.Find ("d");
		e = GameObject.Find ("e");
		f = GameObject.Find ("f");
		g = GameObject.Find ("g");

		meshA = a.GetComponent<MeshRenderer> ();
		meshB = b.GetComponent<MeshRenderer> ();
		meshC = c.GetComponent<MeshRenderer> ();
		meshD = d.GetComponent<MeshRenderer> ();
		meshE = e.GetComponent<MeshRenderer> ();
		meshF = f.GetComponent<MeshRenderer> ();
		meshG = g.GetComponent<MeshRenderer> ();
	}

	void Start () 
	{
		//oculta los punutos de luz
		meshA.enabled = false;
		meshB.enabled = false;
		meshC.enabled = false;
		meshD.enabled = false;
		meshE.enabled = false;
		meshF.enabled = false;
		meshG.enabled = false;

	}

	void Update ()
	{
		//Attack ();
	}

	//Crea un vector de 7 numeros fijos (por la cantidad de puntos de luz en la escena), en orden aleatorio y no repitiente.
	public static void NewSequence()
	{
		System.Random ran = new System.Random();
		randomArray = Enumerable.Range(1, 7).OrderBy(x => ran.Next()).ToArray();

		//muestra los valores
//		for (int x=0; x<randomArray.Length; x++)
//			//Debug.Log (randomArray [x]);
	}

	public static void Attack()
	{

		timer = timer + Time.deltaTime;

		if(timer > timeToTurnOff && On == true)
		{
			meshA.enabled = false;
			meshB.enabled = false;
			meshC.enabled = false;
			meshD.enabled = false;
			meshE.enabled = false;
			meshF.enabled = false;
			meshG.enabled = false;
			timer = 0;
			On = false;
		}
		
		if(timer > timeToTurnOn && acum < randomArray.Length)
		{

			if(randomArray[acum] == 1)
			{
				meshA.enabled = true;
				a.audio.Play();
				//Debug.Log ("se prendio el switche "+(acum+1));
			}
			else if(randomArray[acum] == 2)
			{
				meshB.enabled = true;
				b.audio.Play();
				//Debug.Log ("se prendio el switche "+(acum+1));
			}
			else if(randomArray[acum] == 3)
			{
				meshC.enabled = true;
				c.audio.Play();
				//Debug.Log ("se prendio el switche "+(acum+1));
			}
			else if(randomArray[acum] == 4)
			{
				meshD.enabled = true;
				d.audio.Play();
				//Debug.Log ("se prendio el switche "+(acum+1));
			}
			else if(randomArray[acum] == 5)
			{
				meshE.enabled = true;
				e.audio.Play();
				//Debug.Log ("se prendio el switche "+(acum+1));
			}
			else if(randomArray[acum] == 6)
			{
				meshF.enabled = true;
				f.audio.Play();
				//Debug.Log ("se prendio el switche "+(acum+1));
			}
			else if(randomArray[acum] == 7)
			{
				meshG.enabled = true;
				g.audio.Play();
				//Debug.Log ("se prendio el switche "+(acum+1));
			}
			timer = 0;
			On = true;
			acum++;
		}
		
	}


}
