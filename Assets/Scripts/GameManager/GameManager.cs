﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public InputField width;
	public InputField heigth;
	public int intwidth;
	public int intheigth;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		intwidth = int.Parse(width.text);
		intheigth = int.Parse(heigth.text);
	}

	void Awake(){
		DontDestroyOnLoad(this.gameObject);
	}
}