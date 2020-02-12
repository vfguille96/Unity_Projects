using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirJuego : MonoBehaviour
{

	private bool _ocultar;
	private Canvas _canvas;

	// Use this for initialization
	void Start ()
	{
		_ocultar = false;
		SetCanvasVisible(false);
	}

	private void SetCanvasVisible(bool estado)
	{
		_canvas.gameObject.SetActive(estado);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SalirJuegoMenu();
		}
	}

	private void SalirJuegoMenu()
	{
		if (_ocultar)
		{
			
		}
		else
		{
			
		}
			
	}
}
