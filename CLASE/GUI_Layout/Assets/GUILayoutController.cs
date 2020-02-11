using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GUILayoutController : MonoBehaviour
{
    public Texture _imagen;
    private string texto = "Hola caracola";
    private string textoLbl = "Mira mi etiqueta";
    private string textoArea = "Mucho textaco jasdhfkjashfbdkshnfkldhsnfkldnjsfkldnjsklgf";
    private bool flag;
    private string[] botones = {"Uno", "Dos", "Tres"};
    private int btClick;

    private void Start()
    {
        flag = false;
        btClick = 0;
    }

    private void OnGUI()
    {
        Mostrar();
    }

    private void Mostrar()
    {
        GUI.color = Color.white;
        GUILayout.Space(20); // 20 px de espaciado en el LayoutGroup.
        GUILayout.Label("Etiqueta de GUILayout " + textoLbl);
        if (GUILayout.Button("Destruir mundo"))
            Debug.Log("El mundo no se ha destruido, bruh...");
        if (GUILayout.Button("Con un 6 y un 4..."))
            Debug.Log("...la cara de tu retrato");
        texto = GUILayout.TextField(texto);
        textoArea = GUILayout.TextArea(textoArea);
        flag = GUILayout.Toggle(flag, "On/Off");

        btClick = GUILayout.Toolbar(btClick, botones);
        //textoLbl = textoLbl + " " + btClick;
    }
    
    /*
     * GUILayout.BeginHorizontal() --> A partir de entonces la distribución es Hor. no Vertical (defecto).
     * GUILayout.EndHorizontal() --> Para finalizar.
     *
     *  GUILayout.BeginArea(new Rect()); Para posicionar recpecto a un área.
     */
}