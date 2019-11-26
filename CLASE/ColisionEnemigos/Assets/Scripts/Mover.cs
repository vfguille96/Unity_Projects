using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Añado a la esfera jugador
public class Mover : MonoBehaviour
{
    private const float UMBRAL_DESTRUCCION = 2;
    public float _fuerza = 100F;
    public float _magnitud;
    private Rigidbody _rigidbody;
    public TextMeshPro _TextMeshPro;
    private float _fuerzaSalto = 500F;

    // Use this for initialization
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
            _rigidbody.AddForce(Vector3.up * _fuerzaSalto);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal") * _fuerza * Time.deltaTime,
            0,
            Input.GetAxis("Vertical") * _fuerza * Time.deltaTime), ForceMode.Force);
    }

    private void OnCollisionEnter(Collision other)
    {
        _TextMeshPro.text = other.collider.name + ",  DETECTADO ENEMIGO";
        if (other.gameObject.CompareTag("Enemigo"))
        {
            if (other.relativeVelocity.magnitude > UMBRAL_DESTRUCCION)
                Destroy(other.gameObject, 1);
            _magnitud = other.relativeVelocity.magnitude;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        _TextMeshPro.text = "";
    }
}