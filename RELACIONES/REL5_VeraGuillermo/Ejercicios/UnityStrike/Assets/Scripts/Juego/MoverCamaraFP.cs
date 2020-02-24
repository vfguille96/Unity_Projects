using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamaraFP : MonoBehaviour
{
    private Vector2 LookAxis;
    public FixedTouchField TouchField;

    // Use this for initialization
    void Start()
    {
        //OcultarCursor();
        //DelimitarCursorVentanaPrincipal();
    }

    // Update is called once per frame
    void Update()
    {
        LookAxis = TouchField.TouchDist;
        if (!GameController.TiempoPausado)
            MoverCamaraFPRaton();
    }

    /// <summary>
    /// Oculta el cursor en la ventana principal de ejecución.
    /// </summary>
    private static void OcultarCursor()
    {
        Cursor.visible = false;
    }

    /// <summary>
    /// Delimita el espacio del cursor a la pantalla principal de ejecución.
    /// </summary>
    private static void DelimitarCursorVentanaPrincipal()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    /// <summary>
    /// Mover cámara con los ejes del ratón.
    /// </summary>
    private void MoverCamaraFPRaton()
    {
        if (GameController.InvertirEjeY)
        {
            transform.eulerAngles += new Vector3(
                Mathf.Clamp(LookAxis.y * (GameController.Sensibilidad_Y / 10), -30.5F, 41F),
                LookAxis.x * (GameController.Sensibilidad_X / 10), 0);
        }
        else
        {
            transform.eulerAngles += new Vector3(
                Mathf.Clamp(-LookAxis.y * (GameController.Sensibilidad_Y / 10), -30.5F, 41F),
                LookAxis.x * (GameController.Sensibilidad_X / 10), 0);
        }
    }
}