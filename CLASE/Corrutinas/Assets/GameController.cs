using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

	public GameObject _cubo;
	public float throwRate = 0.3F;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(LanzarCubos());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator LanzarCubos()
	{
		Instantiate(_cubo);
		yield return new WaitForSeconds(throwRate);
		StartCoroutine(LanzarCubos());
	}
}
