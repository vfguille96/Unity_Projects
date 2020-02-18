using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas_V1 : MonoBehaviour
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
		if (Input.GetKeyDown(KeyCode.V))
			StartCoroutine(MoverCubos());
	}

	IEnumerator MoverCubos()
	{
		foreach (var VARIABLE in _cubos)
		{
			yield return StartCoroutine(MoverCubo(VARIABLE));
			yield return StartCoroutine(RotarCubo(VARIABLE));
		}
	}

	IEnumerator MoverCubo(GameObject VARIABLE)
	{
		while (VARIABLE.transform.position.z < destCubos)
		{
			VARIABLE.transform.Translate(vel.x, vel.y, vel.z * Time.deltaTime);
			yield return null;
		}
	}

	IEnumerator RotarCubo(GameObject VARIABLE)
	{
		// Rotación del cubo al llegar al destino
		while (VARIABLE.transform.rotation.eulerAngles.z < 90)
		{
			Vector3 anguloActual = VARIABLE.transform.rotation.eulerAngles;
			Vector3 velRot = new Vector3(0, 0, 50);
			VARIABLE.transform.rotation = Quaternion.Euler(anguloActual + velRot * Time.deltaTime);
			yield return null;
		}
	}
	
	void LocalizarCubos()
	{
		_cubos[0] = GameObject.Find("Cube");
		_cubos[1] = GameObject.Find("Cube (1)");
		_cubos[2] = GameObject.Find("Cube (2)");
	}
}
