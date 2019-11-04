using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class controlText : MonoBehaviour
{
	public TextMeshPro _posicionRaton;
	private float _valor = 0;
	private float _incrTam = 0.001F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//_posicionRaton.text = Input.mousePosition.ToString();
		if (Input.GetMouseButtonDown(0))
			_posicionRaton.text = "Er botonaso izquierdo pisha";
		else if (Input.GetMouseButtonDown(1))
			_posicionRaton.text = "Er botonaso deresho pisha";
		else if (Input.GetMouseButtonDown(2))
		{
			_posicionRaton.text = "To la ruea";
			_valor = 0;
			transform.localScale = Vector3.one;
		}
		else
		{
			_valor += Input.mouseScrollDelta.y;
			_posicionRaton.text = _valor.ToString("0000");
		}
		
		transform.localScale += new Vector3(_valor * _incrTam, _valor * _incrTam, _valor * _incrTam);
	}
}
