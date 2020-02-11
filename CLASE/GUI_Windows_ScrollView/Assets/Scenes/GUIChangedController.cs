using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GUIChangedController : MonoBehaviour
{
    private int btClickId = 0;
    private string[] listacaDeBotones = new[] {"Uno", "Dos", "Tres"};
    public GUIStyle estilos;
    private GUISkin tiposControl;

    private void OnGUI()
    {
        Rect area = new Rect(50, 10, 400, 40);
        btClickId = GUI.Toolbar(area, btClickId, listacaDeBotones, estilos);

        // Identifica qué ha cambiado
        if (GUI.changed)
            Debug.Log("Click en: " + btClickId);
    }
}