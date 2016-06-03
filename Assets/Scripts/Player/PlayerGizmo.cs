using UnityEngine;
using System.Collections;

public class PlayerGizmo : MonoBehaviour {

	public float gizmoSize = 1f;
	public Color gizmoColor = Color.yellow;

	// Use this for initialization
	void OnDrawGizmos()
	{
		Gizmos.color = gizmoColor;
		Gizmos.DrawWireSphere (transform.position, gizmoSize);
	}
}
