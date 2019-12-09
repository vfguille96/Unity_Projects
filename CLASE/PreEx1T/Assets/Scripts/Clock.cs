using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private const float _consH = 360F / 60F;

    private const float _consM = 360F / 5F;

    // Use this for initialization
    public GameObject _hour;
    public GameObject _minute;
    public Slider _slider;

    private void Start()
    {
        _minute.transform.localRotation = Quaternion.Euler(0, 0, 0);
        _hour.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        _minute.transform.localRotation = Quaternion.Euler(0, 0, _slider.value * Time.time * -_consM);
        _hour.transform.localRotation = Quaternion.Euler(0, 0, _slider.value * Time.time * -_consH);
    }
}