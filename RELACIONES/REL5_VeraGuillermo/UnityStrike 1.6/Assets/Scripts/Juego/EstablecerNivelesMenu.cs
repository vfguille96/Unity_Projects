using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstablecerNivelesMenu : MonoBehaviour {

	public void EstablecerNivel1()
	{
		GameController.NivelActual = 1;
	}
	
	public void EstablecerNivel2()
	{
		GameController.NivelActual = 2;
	}
	
	public void EstablecerNivel3()
	{
		GameController.NivelActual = 3;
	}
}
