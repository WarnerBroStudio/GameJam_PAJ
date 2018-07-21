using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
public GameObject condaned;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay (Collider Trigger) {
		if (Input.GetKeyDown("e")){
			condaned.SetActive(true);
		}
	}

	void OnTriggerExit(Collider Trigger) {
		condaned.SetActive(false);
	}
}
