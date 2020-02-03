using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float _vel;
    private Vector3 _dir;
    private int _fruit = 0;
    private TextMeshProUGUI _text;
    public GameObject camera_1;
    public GameObject camera_2;
    private bool _isCamera1Active;
    public GameObject _hodor1;
    public GameObject _canvasExit;

    // Use this for initialization
    void Start()
    {
        _vel = 250;
        _isCamera1Active = true;
        _canvasExit.SetActive(false);
        camera_1.gameObject.SetActive(true);
        camera_2.gameObject.SetActive(false);
        _text = GameObject.Find("TextMeshPro Text").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        ChangeCamera();

        _dir = new Vector3(
            Input.GetAxis("Horizontal") * _vel * Time.deltaTime,
            GetComponent<Rigidbody>().velocity.y,
            Input.GetAxis("Vertical") * _vel * Time.deltaTime);
        transform.LookAt(transform.position + new Vector3(_dir.x, 0, _dir.z));

        if (_fruit == 3)
        {
            _canvasExit.SetActive(true);
            _text.text = Time.realtimeSinceStartup.ToString();
            Time.timeScale = 0;
        }
    }

    private void ChangeCamera()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            if (_isCamera1Active)
            {
                camera_1.gameObject.SetActive(false);
                _isCamera1Active = false;
                camera_2.gameObject.SetActive(true);
            }
            else
            {
                camera_1.gameObject.SetActive(true);
                camera_2.gameObject.SetActive(false);
                _isCamera1Active = true;
            }
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = _dir;


        /*GetComponent<Transform>().Rotate(new Vector3(transform.rotation.x, Input.GetAxis("Mouse X"), transform.rotation.z));
        if (Input.GetKeyDown(KeyCode.W))
            GetComponent<Rigidbody>().AddForce(new Vector3(transform.position.x * _vel, 0, transform.position.z * _vel) * _vel, ForceMode.Impulse);
            */


        /*if (Input.GetKeyDown(KeyCode.S))
            GetComponent<Rigidbody>().AddForce(Vector3.back * _vel, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.A))
            GetComponent<Rigidbody>().AddForce(Vector3.left * _vel, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.D))
            GetComponent<Rigidbody>().AddForce(Vector3.right * _vel, ForceMode.Impulse);*/
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag.Equals("Malacatoneh"))
        {
            _fruit++;
            Destroy(other.gameObject);
            _text.text = "Melocotones: " + _fruit;
        }
    }
}