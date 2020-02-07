using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGUI : MonoBehaviour
{
    public GUIStyle _GuiStyle;
    private int x = 10;
    private int y = 10;
    private int ancho = 200;
    private int alto = 200;
    public string texto = "CROQUETAS DE JAMÓN";
    private bool toglleBol;
    private string[] _botones = {"1", "2", "3"};
    private int btPulsado;

    // Use this for initialization
    void Start()
    {
    }

    private void OnGUI()
    {
        Rect _area = new Rect(x, y, ancho, alto);
        GUI.color = Color.green;

        // Mostrar un label.
        GUI.Label(_area, "BOCADILLO DE CALAMARES", _GuiStyle);


        Rect _areaBt = new Rect(x + 20, y + 20, ancho, alto);

        // Mostrar un botón
        if (GUI.Button(_area, texto))
        {
            Debug.Log("BOTÓN PULSADO");
        }

        Rect _areaBtt = new Rect(x + 40, y + 40, ancho, alto);
        GUI.Button(_areaBtt, new GUIContent("Boton 2", "Mensaje del tooltip"));
        GUI.Label(_areaBtt, GUI.tooltip);

        Rect _areaBttt = new Rect(x + 80, y + 80, ancho, alto);
        texto = GUI.TextField(_areaBttt, texto, 20);

        Rect _areaBtttt = new Rect(x + 100, y + 100, ancho, alto);
        toglleBol = GUI.Toggle(_areaBtttt, toglleBol, "Illo soy un tuggle");
        GameObject.Find("Directional Light").GetComponent<Light>().enabled = toglleBol;
        
        Rect _ultRect = new Rect(x + 150, y + 150, ancho, alto);
        btPulsado = GUI.Toolbar(_ultRect, btPulsado, _botones);
        Debug.Log("Botón pulsado: " + btPulsado);
    }

    // Update is called once per frame
    void Update()
    {
    }
}