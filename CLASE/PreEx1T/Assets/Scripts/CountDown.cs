using System;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Button _Button;
    public Text _Counter;
    private TimeSpan _dateTime;
    public Text _Error;

    private float _inputH;
    public InputField _InputH;
    private float _inputM;
    public InputField _InputM;
    private float _inputS;
    public InputField _InputS;

    private readonly float _maxH = 23;
    private readonly float _maxM = 59;
    private readonly float _maxS = 59;

    // Use this for initialization
    public Slider _Slider;
    private bool _start;

    private void Start()
    {
        _Button.GetComponentInChildren<Text>().text = "Marcha";
        _Button.onClick.AddListener(Pressed);
        _Error.color = Color.black;
        _Slider.value = 0;
        _start = false;
        Time.fixedDeltaTime = 1;
    }

    private void InitializeInputs()
    {
        try
        {
            _inputH = float.Parse(_InputH.text);
            _inputM = float.Parse(_InputM.text);
            _inputS = float.Parse(_InputS.text);
            _Error.color = Color.black;
        }
        catch (Exception)
        {
            SetError();
        }
    }

    private void Pressed()
    {
        if (_Button.name == "Button" && !_start)
        {
            InitializeInputs();

            if (_inputH >= 0 && _inputH <= _maxH &&
                _inputM >= 0 && _inputM <= _maxM &&
                _inputS >= 0 && _inputS <= _maxS)
            {
                _Button.GetComponentInChildren<Text>().text = "Paro";
                _dateTime = new TimeSpan((int) _inputH, (int) _inputM, (int) _inputS);
                _start = true;
            }
            else
            {
                SetError();
            }
        }
        else
        {
            _Counter.text = "00:00:00";
            _Button.GetComponentInChildren<Text>().text = "Marcha";
            _Slider.value = 0;
        }
    }

    private void SetError()
    {
        _Error.color = Color.red;
        _Counter.text = "00:00:00";
    }

    private void FixedUpdate()
    {
        if (_start)
        {
            TimeSpan ts = new TimeSpan(0, 0 ,(int) _Slider.value);
            _dateTime = _dateTime - (ts);
            _Counter.text = _dateTime.ToString();
            if (_Counter.text == "00:00:00")
                _start = false;
        }
    }
}