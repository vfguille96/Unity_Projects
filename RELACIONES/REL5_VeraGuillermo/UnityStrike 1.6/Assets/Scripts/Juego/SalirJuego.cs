using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SalirJuego : MonoBehaviour
{
    private bool _ocultar;
    private Canvas _canvasMenu;
    private TextMeshProUGUI _NombreJugadorUI;
    private Button _BtVolver;
    private Button _BtSalir;

    // Use this for initialization
    void Start()
    {
        _canvasMenu = GameObject.Find("CanvasMenu").gameObject.GetComponent<Canvas>();
        _BtVolver = GameObject.Find("BtVolver").GetComponent<Button>();
        _BtSalir = GameObject.Find("BtSalir").GetComponent<Button>();
        _NombreJugadorUI = GameObject.Find("TMJugador").GetComponent<TextMeshProUGUI>();
        _BtSalir.onClick.AddListener(VolverMenuPrincipal);
        _BtVolver.onClick.AddListener(VolverJuego);
        _ocultar = false;
        SetCanvasVisible(false);
    }

    /// <summary>
    /// Inicialización de componentes del Menú de Pausa.
    /// </summary>
    private void InicializarComponentesCanvasMenu()
    {
        MostrarNombreJugador();
    }

    /// <summary>
    /// Muestra el nombre del jugador, previamente solicitado.
    /// Por defecto se muestra el nombre "Jugador 1".
    /// </summary>
    private void MostrarNombreJugador()
    {
        _NombreJugadorUI.text = GameController.NombreJugador;
        Debug.Log("CANVAS NOMBRE JUGADOR: " + GameController.NombreJugador);
    }

    private void SetCanvasVisible(bool estado)
    {
        _canvasMenu.gameObject.SetActive(estado);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SalirJuegoMenu();

        /*if (GameController.TiempoJuegoRestante == 0 && GameController.TiempoJuego != 0)
            MostrarMenuSalir();*/

    }

    private void SalirJuegoMenu()
    {
        if (_ocultar)
            MostrarMenuSalir();
        else
            OcultarMenuSalir();
    }

    /// <summary>
    /// Muestra el Menú Pausa y pausa el tiempo.
    /// </summary>
    private void MostrarMenuSalir()
    {
        MostrarCursor();
        InicializarComponentesCanvasMenu();
        SetCanvasVisible(true);
        _ocultar = false;
        Time.timeScale = 0;
        GameController.TiempoPausado = true;
    }

    /// <summary>
    /// Oculta el Menú Pausa y reanuda el tiempo pausado.
    /// </summary>
    private void OcultarMenuSalir()
    {
        OcultarCursor();
        SetCanvasVisible(false);
        _ocultar = true;
        Time.timeScale = 1;
        GameController.TiempoPausado = false;
    }

    private void VolverJuego()
    {
        OcultarMenuSalir();
    }

    /// <summary>
    /// Carga la escena Menú Principal.
    /// </summary>
    private void VolverMenuPrincipal()
    {
        OcultarMenuSalir();
        MostrarCursor();
        StopAllCoroutines();
        SceneManager.LoadScene("Menu");
    }
    
    /// <summary>
    /// Muestra el cursor en la ventana principal de ejecución.
    /// </summary>
    private static void MostrarCursor()
    {
        Cursor.visible = true;
    }
    
    /// <summary>
    /// Oculta el cursor en la ventana principal de ejecución.
    /// </summary>
    private static void OcultarCursor()
    {
        Cursor.visible = false;
    }
}