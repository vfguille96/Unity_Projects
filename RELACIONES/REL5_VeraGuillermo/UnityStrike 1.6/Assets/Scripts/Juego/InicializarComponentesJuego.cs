using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicializarComponentesJuego : MonoBehaviour {
	private static int Vida
	{
		get { return 100; }
	}
	
	// Use this for initialization
	void Start ()
	{
		EstablecerVidaJugador();
		EstablecerNombreJugadorPorDefecto();
	}

	private static void EstablecerVidaJugador()
	{
		GameController.Vida = Vida;
	}

	private static void EstablecerNombreJugadorPorDefecto()
	{
		if (GameController.NombreJugador == null)
			GameController.NombreJugador = "Player 1";
	}

	// Update is called once per frame
	void Update () {
		
	}
}
