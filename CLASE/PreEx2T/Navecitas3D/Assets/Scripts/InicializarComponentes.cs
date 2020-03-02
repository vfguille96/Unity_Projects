using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InicializarComponentes : MonoBehaviour
{

	public TextMeshProUGUI TextMeshProUgui;
	public TextMeshProUGUI nivel;
	public GameObject _panel;

	// Use this for initialization
	void Start ()
	{
		GameController.NIVEL_ACTUAL = 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		nivel.text = "NIVEL: " + GameController.NIVEL_ACTUAL;
		TextMeshProUgui.text = "PUNTOS: " + GameController.PUNTOS;

		if (GameController.PUNTOS >= 60 && GameController.PUNTOS <= 179)
			GameController.NIVEL_ACTUAL = 2;
		else if (GameController.PUNTOS >= 180)
			GameController.NIVEL_ACTUAL = 3;


		ComprobarVelNivel();
	}

	private void ComprobarVelNivel()
	{
		switch (GameController.NIVEL_ACTUAL)
		{
			case 1:
				GameController.VEL_ACTUAL = GameController.VEL_LV1;
				_panel.GetComponent<Image>().color = new Color(119 / 255F, 0, 1, 1);
				break;
			case 2:
				GameController.VEL_ACTUAL = GameController.VEL_LV2;
				_panel.GetComponent<Image>().color = new Color(239 / 255F, 0, 131 /255F, 1);
				break;
			case 3:
				GameController.VEL_ACTUAL = GameController.VEL_LV3;
				_panel.GetComponent<Image>().color = new Color(0, 0, 0, 1);
				break;
		}
	}
}
