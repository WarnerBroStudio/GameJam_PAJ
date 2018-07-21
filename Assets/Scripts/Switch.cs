using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour {
	public GameObject Trigger;
	public Player player;
	public Renderer rend;
	public Map map;

	public GameObject E;

	void OnTriggerEnter (Collider Trigger) {
		E.SetActive (true);
	}

	void OnTriggerExit (Collider Trigger) {
		E.SetActive (false);
	}

	void OnTriggerStay (Collider Trigger) {
		if (Input.GetKeyDown ("e")) {
			this.toggleState (Trigger.gameObject.GetComponent<Player> ());
		}
	}

	public void toggleState (Player player) {
		rend.material.color = Color.blue;
		this.player = player;
		this.map.onWallChange ();
	}
}