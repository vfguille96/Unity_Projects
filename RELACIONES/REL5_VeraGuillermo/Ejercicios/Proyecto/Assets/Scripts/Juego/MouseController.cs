using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour
{
    public TextMeshProUGUI _TMSensibilidad;
    public Slider _sliderSensibilidad;
    public Toggle _invertirEjeY;

    private void Start()
    {
        EstablecerSensibilidad();
        EstablecerInvertirEjeY();
    }

    private void EstablecerInvertirEjeY()
    {
        if (GameController.InvertirEjeY)
            _invertirEjeY.isOn = true;
    }

    private void EstablecerSensibilidad()
    {
        if (GameController.Sensibilidad_X != 2)
        {
            _TMSensibilidad.text = GameController.Sensibilidad_X.ToString();
            _sliderSensibilidad.value = GameController.Sensibilidad_X;
        }
    }

    public void AjustarSensibilidad(float sensibilidad)
    {
        GameController.Sensibilidad_X = sensibilidad;
        GameController.Sensibilidad_Y = GameController.Sensibilidad_X;
        _TMSensibilidad.text = sensibilidad.ToString();
    }

    public void InvertirEjeY(bool invertir)
    {
        GameController.InvertirEjeY = invertir;
    }
}