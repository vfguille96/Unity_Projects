using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotonesMenu : MonoBehaviour
{
    public Canvas _CanvasOpciones;
    public InputField _nombreJugador;

    // Use this for initialization
    void Start()
    {
        ActivarCanvasOpciones(false);
        InicializarIFJugador();
    }

    private void InicializarIFJugador()
    {
        if (GameController.NombreJugador != "Player 1" && GameController.NombreJugador != String.Empty)
            _nombreJugador.text = GameController.NombreJugador;
    }

    /// <summary>
    /// Carga la escena Juego
    /// </summary>
    public void BtNuevaPartida()
    {
        GameController.TiempoPausado = false;
        Time.timeScale = 1;
        EstablecerNombreJugador();
        SceneManager.LoadScene("Juego");
    }

    /// <summary>
    /// Activa el Canvas del menú de opciones.
    /// </summary>
    public void BtOpciones()
    {
        ActivarCanvasOpciones(true);
    }

    /// <summary>
    /// Cierra el canvas de opciones.
    /// </summary>
    public void BtSalirCanvasOpciones()
    {
        EstablecerNombreJugador();

        ActivarCanvasOpciones(false);
    }

    private void EstablecerNombreJugador()
    {
        if (_nombreJugador.text != String.Empty)
            GameController.NombreJugador = _nombreJugador.text;
    }


    /// <summary>
    /// Activa/desactiva el componente "CanvasOpciones".
    /// </summary>
    /// <param name="estado">Boolean estado. True, activado. False, desactivado.</param>
    private void ActivarCanvasOpciones(bool estado)
    {
        _CanvasOpciones.gameObject.SetActive(estado);
    }

    /// <summary>
    /// Sale del juego.
    /// </summary>
    public void BtSalir()
    {
        Application.Quit();
    }

    /// <summary>
    /// Sonido al pasar el cursor por encima de los botones del menú.
    /// </summary>
    public void SoundMouseOver()
    {
        GameObject.Find("AudioButtonClick").GetComponent<AudioSource>().Play();
    }
}