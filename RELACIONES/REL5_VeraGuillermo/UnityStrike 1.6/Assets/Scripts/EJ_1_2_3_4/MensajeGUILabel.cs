using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MensajeGUILabel : MonoBehaviour
{
    private bool visualizarVentana;

    Rect area1 = new Rect((Screen.width / 2) - (420 / 2), (Screen.height / 2) - (120 / 2), 420, 120);

    void MostrarVentana(int id)
    {
        GUI.DragWindow();
    }

    void MostrarMensajePantalla(string mensaje)
    {
        area1 = GUI.Window(0, area1, MostrarVentana, mensaje);
    }

    private void Update()
    {
        MostrarV();
    }

    private void MostrarV()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            visualizarVentana = !visualizarVentana;
    }

    // Use this for initialization
    void Start()
    {
        visualizarVentana = false;
    }

    private void OnGUI()
    {
        if (visualizarVentana)
            MostrarMensajePantalla("Soy el mensaje mostrado con GUI.Label");
    }
}