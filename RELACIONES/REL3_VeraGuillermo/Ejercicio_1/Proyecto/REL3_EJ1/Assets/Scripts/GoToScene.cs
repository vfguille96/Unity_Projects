using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToScene : MonoBehaviour
{
	public Button button;
	
	// Use this for initialization
	void Start () {
		
		button.onClick.AddListener(ChangeScene);
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
				QuitGame();
				break;
		}
	}

	public void QuitGame() { Application.Quit(); }

	private void QuitGameEsc()
	{
		if (Input.GetKey(KeyCode.Escape)) QuitGame();
	}
}