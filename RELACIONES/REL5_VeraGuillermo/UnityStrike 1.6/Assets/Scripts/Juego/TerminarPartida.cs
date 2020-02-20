using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TerminarPartida : MonoBehaviour
{
    private Canvas _canvas;
    public TextMeshProUGUI _TMEnemigosEliminados;
    public Button _btEmpezarPartida;
    public Button _btSalirPartidaTerminada;


    // Use this for initialization
    void Start()
    {
        _btEmpezarPartida.onClick.AddListener(CargarEscenaJuego);
        _btSalirPartidaTerminada.onClick.AddListener(VolverMenuPrincipal);
        _canvas = GameObject.Find("CanvasPartidaTerminada").GetComponent<Canvas>();
        _canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.TiempoPausado)
        {
            if (GameController.TiempoJuegoRestante == 0 || GameController.Vida == 0)
                MostrarFinDeJuego();
            if (GameController.NivelActual == 1 &&
                GameController.NumeroEnemigosEliminados == GameController.NumeroEnemigos_L1 + 7)
                MostrarFinDeJuego();
            if (GameController.NivelActual == 2 &&
                GameController.NumeroEnemigosEliminados == GameController.NumeroEnemigos_L2 + 7)
                MostrarFinDeJuego();
            if (GameController.NivelActual == 3 &&
                GameController.NumeroEnemigosEliminados == GameController.NumeroEnemigos_L3 + 7)
                MostrarFinDeJuego();
        }
    }

    private void MostrarFinDeJuego()
    {
        _canvas.gameObject.SetActive(true);
        _TMEnemigosEliminados.text =
            "ENEMIGOS ELIMINADOS: \n\n" + GameController.NumeroEnemigosEliminados;
        GameController.TiempoPausado = true;
        Time.timeScale = 0;
        Cursor.visible = true;
    }

    private void VolverMenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    }

    private void CargarEscenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }
}