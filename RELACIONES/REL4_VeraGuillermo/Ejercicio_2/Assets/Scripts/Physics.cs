using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Physics : MonoBehaviour
{
    public float _vel = 40;
    private Vector3 _dir;
    private int _dropIndex;
    public Text _dirArrow;
    public Text _force;
    private float _posIniX;
    private float _posIniY;
    private float _posIniZ;

    // Use this for initialization
    void Start()
    {
        _dir = Vector3.up;
        _posIniX = transform.position.x;
        _posIniY = transform.position.y;
        _posIniZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        SetDirection();
        ResetBallPosition();
        GoMainMenu();
    }

    private void ResetBallPosition()
    {
        if (Input.GetKeyUp(KeyCode.R))
            transform.SetPositionAndRotation(new Vector3(_posIniX, _posIniY, _posIniZ), Quaternion.identity);
    }

    private void GoMainMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Scenes/Menu");
    }

    private void SetDirection()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _dir = Vector3.up;
            _dirArrow.text = "Dirección: Arriba";
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _dir = Vector3.down;
            _dirArrow.text = "Dirección: Abajo";
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _dir = Vector3.left;
            _dirArrow.text = "Dirección: Izquierda";
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _dir = Vector3.right;
            _dirArrow.text = "Dirección: Derecha";
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            GetComponent<Rigidbody>().AddForce(_dir * _vel, ForceMode.Force);
            _force.text = "Fuerza: Fuerza";
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            GetComponent<Rigidbody>().AddForce(_dir * _vel, ForceMode.Impulse);
            _force.text = "Fuerza: Impulso";
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(_dir * _vel, ForceMode.Acceleration);
            _force.text = "Fuerza: Aceleración";
        }
    }
}