using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Switch : MonoBehaviour {
public GameObject Trigger;
public GameObject Player;
public Renderer rend;

public GameObject E;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider Trigger) {
		E.SetActive(true);
		
	}

	void OnTriggerExit (Collider Trigger) {
		E.SetActive(false);
	}

	void OnTriggerStay (Collider Trigger) {
		if (Input.GetKeyDown ("e")){
			Debug.Log("Yes");
			rend.material.color = Color.blue;
		}
	}
}
