using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    // Use this for initialization
    public GameObject _hour;
    public GameObject _minute;
    public Slider _slider;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _minute.transform.localRotation = Quaternion.Euler(0, 0, _slider.value * Time.time * -(360 / 60) * 12);
        _hour.transform.localRotation = Quaternion.Euler(0, 0, _slider.value * Time.time * -(360F / 120));
    }
}