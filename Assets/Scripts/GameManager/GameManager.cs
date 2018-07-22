using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public InputField width;
	public InputField heigth;
	public Slider slider;
	public static int intwidth;
	public static int intheight;
	public static float difficult;

	// Update is called once per frame
	void Update () {
		GameManager.intwidth = width.text == "" ? 5 : int.Parse (width.text);
		GameManager.intheight = heigth.text == "" ? 5 : int.Parse (heigth.text);
		GameManager.difficult = slider.value;
	}

	// void Awake () {
	// 	DontDestroyOnLoad (this.gameObject);
	// }
}