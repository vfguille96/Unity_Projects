using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	// Use this for initialization
	public Slider _Slider;
	public InputField _InputH;
	public InputField _InputM;
	public InputField _InputS;
	public Button _Button;
	private DateTime _dateTime;
	public Text _Error;

	void Start ()
	{
		_Button.GetComponent<Text>().text = "Marcha";
		_Button.onClick.AddListener(Pressed);
		_Error.color = Color.black;
		_Slider.value = 0;
	}

	private void Pressed()
	{
		if (_Button.name == "Button")
		{
			try
			{
				_dateTime = Convert.ToDateTime(DateTime.Parse(_InputH.text + ":" + _InputM.text + ":" + _InputS.text).ToShortTimeString());
			}
			catch (Exception e)
			{
				_Error.color = Color.red;
				_dateTime = DateTime.Parse("00:00:00");
				return;
			}

			_Button.GetComponent<Text>().text = "Paro";
			
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
