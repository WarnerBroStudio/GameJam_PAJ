using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour {
	public Button play;
	public Button quit;

	void Start () {
		Button btn1 = play.GetComponent<Button> ();
		Button btn2 = quit.GetComponent<Button> ();	
		btn1.onClick.AddListener (TaskOnClick);
		btn2.onClick.AddListener (TaskOnClick2);
	}

	void TaskOnClick () {
		SceneManager.LoadScene ("Level");
		Time.timeScale = 1.0F;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	void TaskOnClick2 () {
		Application.Quit ();
	}

}