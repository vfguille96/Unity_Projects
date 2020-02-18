using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas : MonoBehaviour
{
	private const int NCUBOS = 3;
	GameObject[] _cubos = new GameObject[NCUBOS];
	private float destCubos = 4F;
	Vector3 vel = new Vector3(0, 0, 5.5F);
	private bool iniciarMov = false;

	// Use this for initialization
	void Start () {
		LocalizarCubos();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
			iniciarMov = true;
		MoverCubos();
	}

	void MoverCubos()
	{
		if (iniciarMov)
		{
			if (_cubos[0].transform.position.z < destCubos)
				_cubos[0].transform.Translate(vel.x, vel.y, vel.z * Time.deltaTime);
			else if (_cubos[1].transform.position.z < destCubos)
				_cubos[1].transform.Translate(vel.x, vel.y, vel.z * Time.deltaTime);
			else if (_cubos[2].transform.position.z < destCubos)
				_cubos[2].transform.Translate(vel.x, vel.y, vel.z * Time.deltaTime);
		}
	}
	void LocalizarCubos()
	{
		_cubos[0] = GameObject.Find("Cube");
		_cubos[1] = GameObject.Find("Cube (1)");
		_cubos[2] = GameObject.Find("Cube (2)");
	}
}
