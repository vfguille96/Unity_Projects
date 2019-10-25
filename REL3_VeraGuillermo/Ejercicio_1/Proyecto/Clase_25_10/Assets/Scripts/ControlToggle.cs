using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Asignado al GameObject ControlToggle
 */
public class ControlToggle : MonoBehaviour
{
	public GameObject _toggleLuz;
	private GameObject _luz;
	private GameObject _sound;
	public GameObject _toggleSound;

	// Use this for initialization
	void Start () {
		_luz = GameObject.Find("luz");
		_sound = GameObject.Find("camera");
	}
	
	// Update is called once per frame
	void Update () {
		ControlLuz();
		ControlSound();
	}
	
	/**
	 * Control de On/Off Luz
	 */
	private void ControlLuz()
	{
		_luz.SetActive(_toggleLuz.GetComponent<Toggle>().isOn);
	}

	private void ControlSound()
	{
		_sound.GetComponent<AudioSource>().Play();
	}
}
