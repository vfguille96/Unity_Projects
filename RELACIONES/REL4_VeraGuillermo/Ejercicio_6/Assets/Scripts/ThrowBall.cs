using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using Random = System.Random;

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

    public TextMeshProUGUI _puntuacionTV;
    public Canvas _CanvasScoreTV;
    public Canvas _CanvasStrike;

    public AudioSource _Audio;

    public bool _click;
    public bool _paradinha;
    private bool _collision;
    public static int _score;
    public static int _scoreStrike;
    private Random _random;
    private float[] _angleZ;

    // Use this for initialization
    void Start()
    {
        InitializeParams();
    }

    private void InitializeParams()
    {
        _score = 0;
        _scoreStrike = 0;
        _puntuacionTV.text = _score + "";
        _posIniZ = transform.position.z;
        _paradinha = false;
        _click = false;
        _collision = false;
        _random = new Random();
        _angleZ = new[] {-0.06F, -0.03F, -0.01F, 0.0F, 0.01F, 0.03F, 0.06F};
        _CanvasScoreTV.gameObject.SetActive(true);
        _CanvasStrike.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0) && !_click)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, _angleZ[_random.Next(_angleZ.Length)]) * _random.Next(110, 185),
                ForceMode.Impulse);
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

        if (_click && Math.Abs(GetComponent<Rigidbody>().velocity.x) < 0.5F &&
            Math.Abs(GetComponent<Rigidbody>().velocity.z) < 0.5F
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
                _score++;
                _scoreStrike++;
                Destroy(_bolo1, 0);
            }

            if (Math.Abs(_bolo2.transform.rotation.eulerAngles.x) > 20 ||
                Math.Abs(_bolo2.transform.rotation.eulerAngles.z) > 20)
            {
                _score++;
                _scoreStrike++;

                Destroy(_bolo2, 0);
            }

            if (Math.Abs(_bolo3.transform.rotation.eulerAngles.x) > 20 ||
                Math.Abs(_bolo3.transform.rotation.eulerAngles.z) > 20)
            {
                _score++;
                _scoreStrike++;

                Destroy(_bolo3, 0);
            }

            if (Math.Abs(_bolo4.transform.rotation.eulerAngles.x) > 2 ||
                Math.Abs(_bolo4.transform.rotation.eulerAngles.z) > 20)
            {
                _score++;
                _scoreStrike++;

                Destroy(_bolo4, 0);
            }

            if (Math.Abs(_bolo5.transform.rotation.eulerAngles.x) > 2 ||
                Math.Abs(_bolo5.transform.rotation.eulerAngles.z) > 20)
            {
                _score++;
                _scoreStrike++;

                Destroy(_bolo5, 0);
            }

            if (Math.Abs(_bolo6.transform.rotation.eulerAngles.x) > 2 ||
                Math.Abs(_bolo6.transform.rotation.eulerAngles.z) > 20)
            {
                _score++;
                _scoreStrike++;

                Destroy(_bolo6, 0);
            }

            ShowCanvasStrike();
            SetScore();
            PosOriginBall();
            ResetBooleans();
            DestroyBowls();
            InstantiateBowls();
        }
    }

    private void ShowCanvasStrike()
    {
        if (_scoreStrike == 6)
            StartCoroutine("CheckStrike");
    }

    IEnumerator CheckStrike()
    {
        _CanvasScoreTV.gameObject.SetActive(false);
        _CanvasStrike.gameObject.SetActive(true);
        
        yield return new WaitForSeconds(3);
        
        _CanvasScoreTV.gameObject.SetActive(true);
        _CanvasStrike.gameObject.SetActive(false);
    }

    private void SetScore()
    {
        _puntuacionTV.text = _score + "";
    }

    private void PosOriginBall()
    {
        transform.position = new Vector3(17.48F, 0.5F, 0);
        transform.rotation = new Quaternion();
    }

    private void ResetBooleans()
    {
        FreezeBallRotation();
        _paradinha = false;
        _click = false;
        _collision = false;
        _scoreStrike = 0;
    }

    private void FreezeBallRotation()
    {
        GetComponent<Rigidbody>().freezeRotation = true;
        GetComponent<Rigidbody>().freezeRotation = false;
    }

    private void InstantiateBowls()
    {
        _bolo1 = Instantiate(_bolo1, new Vector3(-17.12F, 0, -0.08F), Quaternion.Euler(0, -60, 0));
        _bolo2 = Instantiate(_bolo2, new Vector3(-18.92F, 0, -0.08F), Quaternion.Euler(0, -60, 0));
        _bolo3 = Instantiate(_bolo3, new Vector3(-18.92F, 0, -1.58F), Quaternion.Euler(0, -60, 0));
        _bolo4 = Instantiate(_bolo4, new Vector3(-18.92F, 0, 1.42F), Quaternion.Euler(0, -60, 0));
        _bolo5 = Instantiate(_bolo5, new Vector3(-18.02F, 0, 0.8200001F), Quaternion.Euler(0, -60, 0));
        _bolo6 = Instantiate(_bolo6, new Vector3(-18.02F, 0, -0.98F), Quaternion.Euler(0, -60, 0));
    }

    private void DestroyBowls()
    {
        Destroy(_bolo1);
        Destroy(_bolo2);
        Destroy(_bolo3);
        Destroy(_bolo4);
        Destroy(_bolo5);
        Destroy(_bolo6);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("PrefBol") && !_collision)
        {
            _Audio.Play();
            _collision = true;
        }
    }
}