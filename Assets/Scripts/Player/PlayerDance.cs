using UnityEngine;
using System.Collections;
using System;

public class PlayerDance : MonoBehaviour {

	GameObject a,b,c,d,e,f,g,black,p0,p1,p2,p3,p4,levelCheck;
	MeshRenderer meshA,meshB,meshC,meshD,meshE,meshF,meshG;
	bool s1,s2,s3,s4,s5,s6,s7;
	LightDance lightDance;
	Animator anim,pa0,pa1,pa2,pa3,pa4,gameState;
	int Colisiones = 0;
	int Intento = 0;
	bool ataque = false;
	bool win = false;
	public int intentosPermitidos = 2;

	// Use this for initialization
	void Start () {

		//for(int x=0;x<7;x++)
		//Debug.Log ("array referencial:"+LightDance.randomArray[x]);

		//Inicializa las referencias
		a = GameObject.Find ("a");
		b = GameObject.Find ("b");
		c = GameObject.Find ("c");
		d = GameObject.Find ("d");
		e = GameObject.Find ("e");
		f = GameObject.Find ("f");
		g = GameObject.Find ("g");
		black = GameObject.Find ("DrBlack");
		levelCheck = GameObject.Find ("LevelManager");

		anim = black.GetComponent<Animator> ();
		gameState = levelCheck.GetComponent<Animator> ();


		p0 = GameObject.Find ("pyramid00");
		p1 = GameObject.Find ("pyramid01");
		p2 = GameObject.Find ("pyramid02");
		p3 = GameObject.Find ("pyramid03");
		p4 = GameObject.Find ("pyramid04");

		pa0 = p0.GetComponent<Animator> ();
		pa1 = p1.GetComponent<Animator> ();
		pa2 = p2.GetComponent<Animator> ();
		pa3 = p3.GetComponent<Animator> ();
		pa4 = p4.GetComponent<Animator> ();

		meshA = a.GetComponent<MeshRenderer> ();
		meshB = b.GetComponent<MeshRenderer> ();
		meshC = c.GetComponent<MeshRenderer> ();
		meshD = d.GetComponent<MeshRenderer> ();
		meshE = e.GetComponent<MeshRenderer> ();
		meshF = f.GetComponent<MeshRenderer> ();
		meshG = g.GetComponent<MeshRenderer> ();
	}

	void Update()
	{
		LightDance.Attack ();

	}

	void OnTriggerExit(Collider area)
	{
		if(area.name == "1" ||
		   area.name == "2" ||
		   area.name == "3" ||
		   area.name == "4" ||
		   area.name == "5" ||
		   area.name == "6" ||
		   area.name == "7")
		{
			anim.SetBool("IsLaughing",false);
		}

	}

	void OnTriggerEnter(Collider area)
	{

	
		if(Convert.ToInt16(area.name) == LightDance.randomArray[0] || s1)
		{ 
			PrendeLaMesh (0);
			s1 = true;
		}
		else
		{
			s1 = false;
			Intento++;
			area.audio.Play();
			anim.SetBool("IsLaughing",true);
			if(Intento > intentosPermitidos)
			{
				LightDance.NewSequence();
				ataque = true;
				Debug.Log (ataque);
				Debug.Log ("Nueva Secuencia");
				LightDance.acum = 0;
				LightDance.timer = 0;
				LightDance.Attack ();
				Intento = 0;
			}
		}

		if(Colisiones > 0)
		{ 
			if((s1 && Convert.ToInt16(area.name) == LightDance.randomArray[1]) || s2)
			{
				s2 = true;
				PrendeLaMesh (1);
			}
			else
			{
				s1 = false;
				s2 = false;
				Debug.Log (" if 1");
				ApagaLasMeshes();
				area.audio.Play();
				anim.SetBool("IsLaughing",true);
				Intento++;
				if(Intento > intentosPermitidos)
				{
					LightDance.NewSequence();
					Debug.Log ("Nueva Secuencia");
					LightDance.acum = 0;
					LightDance.timer = 0;
					LightDance.Attack ();
					Intento = 0;
				}
			}
		}

		if(Colisiones > 1)
		{ 
			if((s1 && s2 && Convert.ToInt16(area.name) == LightDance.randomArray[2]) || s3)
			{
				anim.SetBool("IsLaughing",false);
				s3 = true;
				PrendeLaMesh (2);
			}
			else
			{
				s1 = false;
				s2 = false;
				s3 = false;
				ApagaLasMeshes();
				area.audio.Play();
				anim.SetBool("IsLaughing",true);
				Intento++;
				if(Intento > intentosPermitidos)
				{
					LightDance.NewSequence();
					Debug.Log ("Nueva Secuencia");
					LightDance.acum = 0;
					LightDance.timer = 0;
					LightDance.Attack ();
					Intento = 0;
				}
			}
		}
		if(Colisiones > 2)
		{ 
			if((s1 && s2 && s3 && Convert.ToInt16(area.name) == LightDance.randomArray[3]) || s4)
			{
				s4 = true;
				PrendeLaMesh (3);
			}
			else
			{
				s1 = false;
				s2 = false;
				s3 = false;
				s4 = false;
				Debug.Log (" if 3");
				ApagaLasMeshes();
				area.audio.Play();
				anim.SetBool("IsLaughing",true);
				Intento++;
				if(Intento > intentosPermitidos)
				{
					LightDance.NewSequence();
					Debug.Log ("Nueva Secuencia");
					LightDance.acum = 0;
					LightDance.timer = 0;
					LightDance.Attack ();
					Intento = 0;
				}
			}
		}
		if(Colisiones > 3)
		{ 
			if((s1 && s2 && s3 && s4 && Convert.ToInt16(area.name) == LightDance.randomArray[4]) || s5)
			{
				s5 = true;
				PrendeLaMesh (4);
			}
			else
			{
				s1 = false;
				s2 = false;
				s3 = false;
				s4 = false;
				s5 = false;
				Debug.Log (" if 4");
				ApagaLasMeshes();
				area.audio.Play();
				anim.SetBool("IsLaughing",true);
				Intento++;
				if(Intento > intentosPermitidos)
				{
					LightDance.NewSequence();
					Debug.Log ("Nueva Secuencia");
					LightDance.acum = 0;
					LightDance.timer = 0;
					LightDance.Attack ();
					Intento = 0;
				}
			}
		}
		if(Colisiones > 4)
		{ 
			if((s1 && s2 && s3 && s4 && s5 && Convert.ToInt16(area.name) == LightDance.randomArray[5]) || s6)
			{
				s6 = true;
				PrendeLaMesh (5);	
			}
			else
			{
				s1 = false;
				s2 = false;
				s3 = false;
				s4 = false;
				s5 = false;
				s6 = false;
				ApagaLasMeshes();
				area.audio.Play();
				anim.SetBool("IsLaughing",true);
				Intento++;
				if(Intento > intentosPermitidos)
				{
					LightDance.NewSequence();
					Debug.Log ("Nueva Secuencia");
					LightDance.acum = 0;
					LightDance.timer = 0;
					LightDance.Attack ();
					Intento = 0;
				}
				//Colisiones++;
			}
		}
		if(Colisiones > 5)
		{ 
			if((s1 && s2 && s3 && s4 && s5 && s6 && Convert.ToInt16(area.name) == LightDance.randomArray[6]) || s7)
			{
				s7 = true;
				PrendeLaMesh (6);
				pa0.SetBool("Win",true);
				pa1.SetBool("Win",true);
				pa2.SetBool("Win",true);
				pa3.SetBool("Win",true);
				pa4.SetBool("Win",true);
				black.SetActive(false);

				gameState.SetBool("Win",true);

	
			}
			else
			{
				s1 = false;
				s2 = false;
				s3 = false;
				s4 = false;
				s5 = false;
				s6 = false;
				s7 = false;
				ApagaLasMeshes();
				area.audio.Play();
				anim.SetBool("IsLaughing",true);
				Intento++;
				if(Intento > intentosPermitidos)
				{
					LightDance.NewSequence();
					Debug.Log ("Nueva Secuencia");
					LightDance.acum = 0;
					LightDance.timer = 0;
					LightDance.Attack ();
					Intento = 0;
				}
			}
		}

		if(!s1)
		{
			Colisiones = 0;
		}
		else
		{
			Colisiones++;
		}


	}

	void ApagaLasMeshes()
	{
		meshA.enabled = false;
		meshB.enabled = false;
		meshC.enabled = false;
		meshD.enabled = false;
		meshE.enabled = false;
		meshF.enabled = false;
		meshG.enabled = false;
	}

	void PrendeLaMesh(int n)
	{
		if(LightDance.randomArray[n] == 1)
		{
			meshA.enabled = true;
		}
		else if(LightDance.randomArray[n] == 2)
		{
			meshB.enabled = true;
		}
		else if(LightDance.randomArray[n] == 3)
		{
			meshC.enabled = true;
		}
		else if(LightDance.randomArray[n] == 4)
		{
			meshD.enabled = true;
		}
		else if(LightDance.randomArray[n] == 5)
		{
			meshE.enabled = true;
		}
		else if(LightDance.randomArray[n] == 6)
		{
			meshF.enabled = true;
		}
		else if(LightDance.randomArray[n] == 7)
		{
			meshG.enabled = true;
		}
	}

}
