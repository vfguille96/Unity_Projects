using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipalController : MonoBehaviour {

	// Update is called once per frame
	void Update ()
	{
		SalirDelJuego();
	}

	private static void SalirDelJuego()
	{
		if (Input.GetKeyUp(KeyCode.Escape))
			Application.Quit();
	}
	
	public void CargarEj5_7_8_9_10_11()
	{
		SceneManager.LoadScene("Scenes/Juego/Menu");
	}

	public void CargarEj1_2_3_6()
	{
		SceneManager.LoadScene("EJ_1_2_3_6");
	}
}
