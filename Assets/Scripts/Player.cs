using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public GameObject Camera;
	public String name;
	public int score = 0;
	public Text[] scoreText;
	public Color color;

	public void updateScore () {
		for (int i = 0; i < this.scoreText.Length; i++) {
			this.scoreText[i].text = "Score: " + this.score;
		}
	}
}