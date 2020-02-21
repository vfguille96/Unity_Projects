using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicializarOpcionesMenu : MonoBehaviour
{
    private Canvas _canvasAyuda;

    // Use this for initialization
    void Start()
    {
        _canvasAyuda = GameObject.Find("CanvasAyuda").GetComponent<Canvas>();

        if (GameController.MostrarAyuda)
        {
            _canvasAyuda.gameObject.SetActive(true);
            GameController.MostrarAyuda = false;
        }
        else
            OcultarCanvasAyuda();
    }

    private void OcultarCanvasAyuda()
    {
        _canvasAyuda.gameObject.SetActive(false);
    }

    public void CerrarCanvasAyuda()
    {
        OcultarCanvasAyuda();
    }
}