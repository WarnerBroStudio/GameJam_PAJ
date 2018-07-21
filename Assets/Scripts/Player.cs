using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public GameObject Camera;
	public String name;
	public int score = 0;
	public Text scoreText;

	public void updateScore () {
		this.scoreText.text = "Score: " + this.score;
	}
}