using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToScene : MonoBehaviour
{
	public Button button;
	private Canvas canvas;

	// Use this for initialization
	void Start () {
		
		button.onClick.AddListener(ChangeScene);
		canvas = GameObject.Find("CanvasConf").GetComponent<Canvas>();
		canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		QuitGameEsc();
	}

	

	public void ChangeScene()
	{
		switch (button.name)
		{
			case "btEsc1":
				SceneManager.LoadScene("Menu1");
				break;
			case "btEsc2":
				SceneManager.LoadScene("Menu2");
				break;
			case "btEsc3":
				SceneManager.LoadScene("Menu3");
				break;
			case "btEsc4":
				SceneManager.LoadScene("Menu4");
				break;
			case "btEscape":
				canvas.enabled = true;
				break;
			case "btSalir":
				QuitGame();
				break;
			case "btVolver":
				canvas.enabled = false;
				break;
		}
	}

	public void QuitGame() { Application.Quit(); }

	private void QuitGameEsc()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			canvas.enabled = true;
		}
	}
}