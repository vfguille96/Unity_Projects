using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasControl : MonoBehaviour
{
	public static bool _Gas = true;
	private float _incr = 10;
	public Slider _slider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Z to incr. gas
		if (Input.GetKeyDown(KeyCode.Z))
		{
			_slider.value += _incr;
			_Gas = true;
		}
		
		// Decr. gas X
		if (Input.GetKeyDown(KeyCode.X))
		{
			_slider.value -= _incr;
			_Gas = true;
			if (_slider.value <= 0)
				_Gas = false;
		}
	}
}
