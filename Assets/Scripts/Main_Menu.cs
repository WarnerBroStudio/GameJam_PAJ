using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour {
public Button play;
public Button quit;

	// Use this for initialization
	void Start () {

	Button btn1 = play.GetComponent<Button>();
	Button btn2 = quit.GetComponent<Button>();
	btn1.onClick.AddListener(TaskOnClick);
	btn2.onClick.AddListener(TaskOnClick2);
	}

	void TaskOnClick (){
		SceneManager.LoadScene("Level");
	}

	void TaskOnClick2 (){
		Application.Quit();
	}
	
}
