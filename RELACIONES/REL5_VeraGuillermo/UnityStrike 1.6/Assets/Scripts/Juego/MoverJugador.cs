using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MoverJugador : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float _vel;
    public float _salto;
    private static bool _suelo;
    public GameObject _camara;
    private MouseLook _mouseLook;
    private GameObject _cuerpo;

    // Use this for initialization
    void Start()
    {
        //_mouseLook = new MouseLook();
        //_mouseLook.Init(transform,_camara.transform);
        _rigidbody = GetComponent<Rigidbody>();
        _cuerpo = GameObject.Find("arctic_Armature");
        _suelo = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, 0);
        _cuerpo.transform.localEulerAngles = new Vector3(-90, _camara.transform.localEulerAngles.y + 180, 0);
        Salto();
    }

    private void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _suelo)
            _rigidbody.AddForce(transform.up * _salto);
    }

    private void FixedUpdate()
    {
        //_mouseLook.UpdateCursorLock();
        _rigidbody.MovePosition(transform.position + _camara.transform.forward * (Input.GetAxis("Vertical") * _vel) +
                                _camara.transform.right * (Input.GetAxis("Horizontal") * _vel));
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Equals("dust2_map"))
            _suelo = true;
        else
            _suelo = false;
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name.Equals("dust2_map"))
            _suelo = false;
        else
            _suelo = true;
    }
}