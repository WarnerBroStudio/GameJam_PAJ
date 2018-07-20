using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
public Text Texte;
public int chrono;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Time",1f, 1f);
		Texte = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Time () {
		chrono++;
		Texte.text = "Time : " + chrono;
	}
}
