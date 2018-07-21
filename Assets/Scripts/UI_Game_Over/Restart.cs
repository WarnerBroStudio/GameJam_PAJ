using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
public Button restart;
public Button quit;

	// Use this for initialization
	void Start () {

	Button btn1 = restart.GetComponent<Button>();
	Button btn2 = quit.GetComponent<Button>();
	btn1.onClick.AddListener(TaskOnClick);
	btn2.onClick.AddListener(TaskOnClick2);
	}

	void TaskOnClick (){
		SceneManager.LoadScene("Main_Menu");
		Time.timeScale = 1.0F;
	}

	void TaskOnClick2 (){
		Application.Quit();
	}
	
}
