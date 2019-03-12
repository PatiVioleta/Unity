using UnityEngine;
using System.Collections;

public class drag : MonoBehaviour {
	float distance = 10;
	void OnMouseDrag(){
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, 0, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		transform.position = objPosition;
	}
}
