using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;
using Button = UnityEngine.UI.Button;

public class ChangeScene : MonoBehaviour {

	// Use this for 
	public Button _button;
	public Canvas _canvas;
	private GameObject _gameObject;
	void Start () {
		_button.onClick.AddListener(cambiarEscena);
		_gameObject = _canvas.gameObject;
		_gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void cambiarEscena()
	{
		switch (_button.name)
		{
			case "btSalir":
				Application.Quit();
				break;
			case "btVolver":
				_gameObject.SetActive(false);
				break;
			case "Reloj analógico":
				SceneManager.LoadScene("Scenes/Reloj analógico");
				break;
			case "Descontador digital":
				SceneManager.LoadScene("Scenes/Cuenta atrás");
				break;
			case "Salir":
				_gameObject.SetActive(true);
				break;
		}
	}
}
