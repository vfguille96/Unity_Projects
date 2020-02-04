using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class EnemyGiz : MonoBehaviour
{

	public float range = 2;
	private List<GameObject> _enemy;
	public Transform _father;
	
	// hijo.transform.parent = padre    El hijo se añade al padre.

	// Use this for initialization
	void Start () {
		_enemy = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));

		foreach (Transform VARIABLE in _father)
		{
			Debug.Log(VARIABLE.gameObject.name);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	private void OnDrawGizmos()
	{
		if (_enemy != null || _enemy.Count != 0)
		{
			Gizmos.color = Color.red;
			float _distance = float.MaxValue;
			GameObject _enemNear = null;

			foreach (GameObject gameObject in _enemy)
			{
				float distance = Vector3.Distance(transform.position, gameObject.transform.position);
				if (distance < _distance)
				{
					_distance = distance;
					_enemNear = gameObject;
				}

				if (_enemNear != null)
				{
					Gizmos.DrawLine(transform.position, _enemNear.transform.position);
				}
			}
		}else
			return;
		
		
		
		

	}
}
