using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
	private GameObject _gameObject;

	// Use this for initialization
	void Start ()
	{
		_gameObject = GameObject.Find("w_pist_deagle");
	}
	
	// Update is called once per frame
	void Update ()
	{
		StartCoroutine(DisparoEagle());
	}

	private IEnumerator DisparoEagle()
	{
		if (Input.GetMouseButtonDown(0))
		{
			_gameObject.GetComponent<AudioSource>().Play();
			_gameObject.GetComponent<Animation>().Play();
		}
		yield return new WaitForSecondsRealtime(0.5F);
	}
}
