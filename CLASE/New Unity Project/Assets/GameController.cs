using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

[Serializable]
public struct PlayerData
{
	public String _name;
	public int _puntos;
}

// Atributo que indica se ejecute el Script en modo de edición. Justo después de compilarse. Sin darle al Play.
[ExecuteInEditMode]

// Ayuda del Script. Va a la URL al darle al icono del 'librito' en el componente, al componente del objeto que ha sido asignado.
[HelpURL("https://github.com/vfguille96/Unity_Projects")]

// No permite la asignación a múltiples componentes.
[DisallowMultipleComponent]

// El objeto necesita el componente indicado. No permite borrar dicho componente al tener asignado el tipo. 
[RequireComponent(typeof(Rigidbody))]
public class GameController : MonoBehaviour
{
	public PlayerData PlayerData;

	public float _value;
	
	// Sirve para ocultar el campo público en el inspector.
	[HideInInspector]
	public float _vel;

	[Header("Arrastra un enemigo")] public GameObject _GameObject;

	// Intervalo.
	[Range(1, 5)] public int _lives = 1;
	
	[SerializeField] private bool _action;

	// Ayuda al posicionar el cursor sobre el nombre del campo.
	[Tooltip("Representa el tiempo que dura un enemigo")]
	public float _time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
