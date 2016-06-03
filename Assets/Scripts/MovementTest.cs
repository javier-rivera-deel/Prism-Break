using UnityEngine;
using System.Collections;

public class MovementTest : MonoBehaviour {
	private RaycastHit rayHit;
	private GameObject collideObj;
	private float distance;//distance between camera and pivot point of game object
	private Vector3 posObj;
	private bool lockObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetMouseButton (0)) {
						var ray = camera.ScreenPointToRay (Input.mousePosition);
						var hit = Physics.Raycast (ray.origin, ray.direction, out rayHit);
						if (hit && !lockObj) {
								collideObj = rayHit.collider.gameObject;
								distance = rayHit.distance;
								Debug.Log (collideObj.name);

								/*
				 * Esto hace que al hacer click a un gameobject se active la animacion
				 * 
				GameObject tower = GameObject.Find("tower");
				tower.GetComponent<Animator> ().SetBool ("CanOpen", true);

						}
						lockObj = true;
						posObj = ray.origin + distance * ray.direction;
						collideObj.transform.position = new Vector3 (posObj.x, 0f, 0f);
				} 
				else
				{
					lockObj = false;
				}
				*/
	}
}
