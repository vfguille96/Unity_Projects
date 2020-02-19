using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TerminarPartida : MonoBehaviour
{
	private Canvas _canvas;
	public TextMeshProUGUI _TMEnemigosEliminados;
	public Button _btEmpezarPartida;
	public Button _btSalir;
	

	// Use this for initialization
	void Start () {
		_btEmpezarPartida.onClick.AddListener(CargarEscenaJuego);
		_btEmpezarPartida.onClick.AddListener(VolverMenuPrincipal);
		_canvas = GameObject.Find("CanvasPartidaTerminada").GetComponent<Canvas>();
		_canvas.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.TiempoJuegoRestante == 0 || GameController.Vida == 0)
		{
			_canvas.gameObject.SetActive(true);
			_TMEnemigosEliminados.GetComponent<Text>().text =
				"ENEMIGOS ELIMINADOS: \n\n" + GameController.NumeroEnemigosEliminados;
			Time.timeScale = 0;
			GameController.TiempoPausado = true;
			Cursor.visible = true;
			StopAllCoroutines();
		}
	}
	
	private void VolverMenuPrincipal()
	{
		SceneManager.LoadScene("Menu");
	}

	private void CargarEscenaJuego()
	{
		SceneManager.LoadScene("Juego");
	}
}
