using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public InputField width;
	public InputField heigth;
	public static int intwidth;
	public static int intheigth;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Debug.Log (width.text);
		GameManager.intwidth = width.text == "" ? 5 : int.Parse (width.text);
		GameManager.intheigth = heigth.text == "" ? 5 : int.Parse (heigth.text);
	}

	// void Awake () {
	// 	DontDestroyOnLoad (this.gameObject);
	// }
}