using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {
	public GameObject A;
	public GameObject B;
	public GameObject Warper;
	

	Vector3 aPos;
	Vector3 bPos;
	Vector3 wPos;

	void Awake()
	{
		wPos = Warper.GetComponent<Transform> ().position;
		aPos = A.GetComponent<Transform> ().position;
		bPos = B.GetComponent<Transform> ().position;
	}

	void Start()
	{
		Debug.Log (wPos);
		Debug.Log (aPos);
		Debug.Log (bPos);
	}


	void OnTriggerEnter(Collider warp)
	{
		if(warp.name == "A")
		{
			Debug.Log ("warping..");
			Warper.GetComponent<Transform> ().position.Set
				(bPos.x,bPos.y,bPos.z);

			Debug.Log (wPos);
			Debug.Log (aPos);
			Debug.Log (bPos);
		}
		else if(warp.name == "B")
		{
			//wPos = aPos;
		}
	}
}
