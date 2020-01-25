using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class ThrowBall : MonoBehaviour
{
    private float _maxZ = 4;
    private float _minZ = -4;
    private float _posIniZ;
    private float _posZ = 0;

    public GameObject _bolo1;
    public GameObject _bolo2;
    public GameObject _bolo3;
    public GameObject _bolo4;
    public GameObject _bolo5;
    public GameObject _bolo6;
    
    
    public GameObject _bolo1t;
    public GameObject _bolo2t;
    public GameObject _bolo3t;
    public GameObject _bolo4t;
    public GameObject _bolo5t;
    public GameObject _bolo6t;

    public TextMeshProUGUI _puntuacionTV;

    public Transform _grupoBolos;

    private bool _click;
    private bool _paradinha;
    public static int _puntuacion;
    private Transform _posBola;

    // Use this for initialization
    void Start()
    {
        // _bolo1t = _bolo1.gameObject.GetComponent<GameObject>();
        // _bolo2t = _bolo1.gameObject.GetComponent<GameObject>();
        // _bolo3t = _bolo1.gameObject.GetComponent<GameObject>();
        // _bolo4t = _bolo1.gameObject.GetComponent<GameObject>();
        // _bolo5t = _bolo1.gameObject.GetComponent<GameObject>();
        // _bolo6t = _bolo1.gameObject.GetComponent<GameObject>();
        
        
        _paradinha = false;
        _puntuacion = 0;
        _posBola = transform;
        _puntuacionTV.text = _puntuacion + "";
        _posIniZ = transform.position.z;
        _click = false;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(1) && !_click)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 165, ForceMode.Impulse);
            _click = true;
        }
    }

    private void Update()
    {
        if (!_click && !_paradinha)
        {
            _posZ += Input.GetAxis("Mouse X") * Time.deltaTime * 10;
            _posZ = Mathf.Clamp(_posZ, _minZ + _posIniZ, _maxZ + _posIniZ);

            transform.position = new Vector3(transform.position.x, transform.position.y, _posZ);
        }

        // Debug.LogFormat("X: " + _bolo1.transform.rotation.x);
        // Debug.LogFormat("Z: " + _bolo1.transform.rotation.z);
        // Debug.LogFormat(GetComponent<Rigidbody>().velocity.normalized.ToString());

        if (_click && Math.Abs(GetComponent<Rigidbody>().velocity.x) < 0.5F && Math.Abs(GetComponent<Rigidbody>().velocity.z) < 0.5F
            && Math.Abs(GetComponent<Rigidbody>().velocity.y) < 0.5F)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            _paradinha = true;
        }
        
        if (_click && _paradinha && GetComponent<Rigidbody>().velocity.normalized == Vector3.zero)
        {
            
            if (Math.Abs(_bolo1.transform.rotation.eulerAngles.x) > 20 ||
                Math.Abs(_bolo1.transform.rotation.eulerAngles.z) > 20)
            {
                _puntuacion++;
                Destroy(_bolo1, 0);
            }
                
            if (Math.Abs(_bolo2.transform.rotation.eulerAngles.x) > 20 || Math.Abs(_bolo2.transform.rotation.eulerAngles.z) > 20)
            {
                _puntuacion++;
                Destroy(_bolo2, 0);
            }
            if (Math.Abs(_bolo3.transform.rotation.eulerAngles.x) > 20 || Math.Abs(_bolo3.transform.rotation.eulerAngles.z) > 20)
            {
                _puntuacion++;
                Destroy(_bolo3, 0);
            }
            if (Math.Abs(_bolo4.transform.rotation.eulerAngles.x) > 2 || Math.Abs(_bolo4.transform.rotation.eulerAngles.z) > 20)
            {
                _puntuacion++;
                Destroy(_bolo4, 0);
            }
            if (Math.Abs(_bolo5.transform.rotation.eulerAngles.x) > 2 || Math.Abs(_bolo5.transform.rotation.eulerAngles.z) > 20)
            {
                _puntuacion++;
                Destroy(_bolo5, 0);
            }
            if (Math.Abs(_bolo6.transform.rotation.eulerAngles.x) > 2 || Math.Abs(_bolo6.transform.rotation.eulerAngles.z) > 20)
            {
                _puntuacion++;
                Destroy(_bolo6, 0);
            }
            
            _puntuacionTV.text = _puntuacion + "";
            transform.position =  new Vector3(17.48F, 0.5F, 0);
            GetComponent<Rigidbody>().freezeRotation = true;
            transform.rotation = new Quaternion();
            GetComponent<Rigidbody>().freezeRotation = false;
            _paradinha = false;
            _click = false;
            Destroy(_bolo1);
            Destroy(_bolo2);
            Destroy(_bolo3);
            Destroy(_bolo4);
            Destroy(_bolo5);
            Destroy(_bolo6);

            _bolo1=Instantiate(_bolo1,new Vector3(-17.12F,0,-0.08F),Quaternion.Euler(0,-60,0));
            _bolo2=Instantiate(_bolo2,new Vector3(-18.92F,0,-0.08F),Quaternion.Euler(0,-60,0));
            _bolo3=Instantiate(_bolo3,new Vector3(-18.92F,0,-1.58F),Quaternion.Euler(0,-60,0));
            _bolo4=Instantiate(_bolo4,new Vector3(-18.92F,0,1.42F),Quaternion.Euler(0,-60,0));
            _bolo5=Instantiate(_bolo5,new Vector3(-18.02F,0,0.8200001F),Quaternion.Euler(0,-60,0));
            _bolo6=Instantiate(_bolo6,new Vector3(-18.02F,0,-0.98F),Quaternion.Euler(0,-60,0));
        }
    }
}