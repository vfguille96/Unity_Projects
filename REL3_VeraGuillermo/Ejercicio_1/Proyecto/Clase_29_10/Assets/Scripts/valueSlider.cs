using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valueSlider : MonoBehaviour
{
	public GameObject _texto;
	public GameObject _slider;
	private Text _text;
	private Slider _slider1;
	public GameObject _dropDown;
	private String[] _dias = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes"};
	private List<Dropdown.OptionData> _list;

	// Use this for initialization
	void Start ()
	{
		_slider1 = _slider.GetComponent<Slider>();
		_text = _texto.GetComponent<Text>();
		_list = new List<Dropdown.OptionData>();
		foreach (var dia in _dias)
			_list.Add(new Dropdown.OptionData(dia));
		_dropDown.GetComponent<Dropdown>().options = _list;
		_dropDown.GetComponent<Dropdown>().value = 2;
		ActualizaValor();
	}
	
	// Update is called once per frame
	void Update () {
		ActualizaValor();
	}

	public void ActualizaValor()
	{
		_text.text = _slider1.value.ToString("000");
	}
}
