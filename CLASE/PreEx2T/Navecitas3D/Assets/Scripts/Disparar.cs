using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
	public GameObject _misil;
	private GameObject _misil_pref;
	public float _vel;
	private bool disparo;

	// Use this for initialization
	void Start ()
	{
		disparo = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && !disparo)
		{
			_misil_pref = Instantiate(_misil, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity, GameObject.FindWithTag("Player").transform);
			_misil_pref.GetComponent<Rigidbody2D>().AddForce(Vector2.right * _vel, ForceMode2D.Impulse);
			Destroy(_misil_pref, 3);
			disparo = true;
			StartCoroutine(Esperar());
		}
	}

	private IEnumerator Esperar()
	{
		yield return new WaitForSeconds(0.3F);
		disparo = false;
	}
}
