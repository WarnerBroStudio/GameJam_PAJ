using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_Map : MonoBehaviour {
	public GameObject Camera;

	void Update () {
		if (Input.GetAxis ("Mouse ScrollWheel") > 0F) {
			if (Camera.transform.position.y <= 100) {
				Camera.transform.position += Vector3.up * 10F;
			}
		}

		if (Input.GetAxis ("Mouse ScrollWheel") < 0F) {
			if (Camera.transform.position.y >= 30) {
				Camera.transform.position += Vector3.down * 10F;
			}
		}

	}
}