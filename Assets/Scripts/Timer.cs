using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text Texte;
	public int chrono;
	public bool death;
	public GameObject UI_death;
	public Player enemy;
	public GameObject UI_Plauer;

	void Start () {
		InvokeRepeating ("Timing", 1f, 1f);
	}

	void Timing () { chrono--; }

	void Update () {
		Texte.text = "Temps : " + chrono;
		if (chrono == 0) { death = true; }
		if (death == true) {
			UI_Plauer.SetActive(false);
			UI_death.SetActive (true);
			Time.timeScale = 0.0F;
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			{
				
			}
		}
	}

}