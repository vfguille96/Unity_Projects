using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EstablecerNivelesMenu : MonoBehaviour
{

	public TextMeshProUGUI _TMDificultad;

	public void EstablecerNivel1()
	{
		GameController.NivelActual = 1;
		_TMDificultad.text = "Dificultad: Nivel 1";
	}
	
	public void EstablecerNivel2()
	{
		GameController.NivelActual = 2;
		_TMDificultad.text = "Dificultad: Nivel 2";
	}
	
	public void EstablecerNivel3()
	{
		GameController.NivelActual = 3;
		_TMDificultad.text = "Dificultad: Nivel 3";

	}
}
