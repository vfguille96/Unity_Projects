using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamaraFP : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        OcultarCursor();
        DelimitarCursorVentanaPrincipal();
    }

    // Update is called once per frame
    void Update()
    {
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
            transform.eulerAngles += new Vector3(Mathf.Clamp(Input.GetAxis("Mouse Y") * GameController.Sensibilidad_Y, -30.5F, 41F),
                Input.GetAxis("Mouse X") * GameController.Sensibilidad_X, 0);
        }
        else
        {
            transform.eulerAngles += new Vector3(Mathf.Clamp(-Input.GetAxis("Mouse Y") * GameController.Sensibilidad_Y, -30.5F, 41F),
                Input.GetAxis("Mouse X") * GameController.Sensibilidad_X, 0);
        }
    }
}