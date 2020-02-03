using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{

	public Canvas _Canvas;
	public Button _btBack;
	public Button _btExit;
	public GameObject _ball;
	
	// Use this for initialization
	void Start () {
		_Canvas.gameObject.SetActive(false);
		_btBack.onClick.AddListener(HideCanvas);
		_btExit.onClick.AddListener(ExitGameBt);
	}

	private void ExitGameBt()
	{
		Application.Quit();
	}

	private void HideCanvas()
	{
		_Canvas.gameObject.SetActive(false);
		_ball.GetComponent<ThrowBall>().gameObject.SetActive(true);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			_Canvas.gameObject.SetActive(true);
			_ball.GetComponent<ThrowBall>().gameObject.SetActive(false);
		}
	}
}
