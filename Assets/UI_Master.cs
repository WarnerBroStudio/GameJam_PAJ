using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Master : MonoBehaviour {
	public GameObject UI_pause;
	public GameObject UI_Player;
	public Button reprendre;
	public Button MainMenu;
	public Button quit;

	void Start () {
		Button btn0 = reprendre.GetComponent<Button>();
		Button btn1 = MainMenu.GetComponent<Button>();
		Button btn2 = quit.GetComponent<Button>();
		btn0.onClick.AddListener(TaskOnClick0);
		btn1.onClick.AddListener(TaskOnClick1);
		btn2.onClick.AddListener(TaskOnClick2);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("escape")){
			UI_pause.SetActive(true);
			Time.timeScale = 0.0F;
			Cursor.visible = true;
		}
	}

	void TaskOnClick0(){
		UI_pause.SetActive(false);
		Time.timeScale = 1.0F;
		Cursor.visible = false;
	}

	void TaskOnClick1(){
		Time.timeScale = 1.0F;
		SceneManager.LoadScene("Main_Menu");
		Time.timeScale = 1.0F;
	}

	void TaskOnClick2(){
		Application.Quit();
	}
}
