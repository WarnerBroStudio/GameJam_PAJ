using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
public Text Texte;
public int chrono;
public bool death;
public GameObject UI_death;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Timing",1f, 1f);
		Texte = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Timing () {
		chrono--;
	}
	void Update () {
		Texte.text = "Time : " + chrono;
		if (chrono == 0){
			death = true;
		}
		if (death == true){
			UI_death.SetActive(true);
			Time.timeScale = 0.0F;
		}
	}

}
