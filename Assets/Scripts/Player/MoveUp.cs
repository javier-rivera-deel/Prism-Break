using UnityEngine;
using System.Collections;

public class MoveUp : MonoBehaviour {

	float UpPosX = -63.94f;
	float UpPosY = 50.165f;
	float UpPosZ = -74.96f;

	float DownPosX = -60.82f;
	float DownPosY = 10.91f;
	float DownPosZ = -113.77f;

	//posiciones para la escena impossibler
	float Ax = -29.30f;
	float Ay = 1.99f;
	float Az = -8.28f;
	float Bx = -30.44f;
	float By = 5.02f;
	float Bz = -4.24f;
	float Cx = -35.67f;
	float Cy = 8.65f;
	float Cz = -1.70f;

	bool heIsUp;
	bool level1;
	bool level2;
	bool level3;

	
	void OnTriggerEnter(Collider other)
	{
		GameObject player = GameObject.Find ("player");
		if(other.name == "Up")
		{
			player.transform.position = new Vector3 (UpPosX,UpPosY,UpPosZ);
			heIsUp = true;
		}
		if(other.name == "Down" && heIsUp)
		{
			player.transform.position = new Vector3 (DownPosX,DownPosY,DownPosZ);
		}
		if(other.name == "a < -> B")
		{
			player.transform.position = new Vector3(Cx,Cy,Cz);

		}
		if(other.name == "A < -> b")
		{
			player.transform.position = new Vector3(Ax,Ay,Az);
			
		}
		if(other.name == "C < -> d")
		{
			player.transform.position = new Vector3(Bx,By,Bz);
			
		}
		if(other.name == "c < -> D")
		{
			player.transform.position = new Vector3(Cx,Cy,Cz);
			
		}


	}
}
