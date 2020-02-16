using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class InicializarComponentesJuego : MonoBehaviour
{
    private TextMeshProUGUI _healthUI;
    private TextMeshProUGUI _bullethUI;
    private TextMeshProUGUI _TimeUI;
    private float _tiempoJuegoActual;
    private TimeSpan _timeSpan;
    
    
    private static int Vida
    {
        get { return 100; }
    }

    private static int BalasTotales
    {
        get { return 42; }
    }

    private static int BalasCargador
    {
        get { return 7; }
    }

    private static int BalasRestantes
    {
        get { return 35; }
    }

    // Use this for initialization
    void Start()
    {
        EstablecerVidaJugador();
        EstablecerNombreJugadorPorDefecto();
        EstablecerBalas();
        _healthUI = GameObject.Find("Health").GetComponent<TextMeshProUGUI>();
        _bullethUI = GameObject.Find("Bullet").GetComponent<TextMeshProUGUI>();
        _TimeUI = GameObject.Find("Time").GetComponent<TextMeshProUGUI>();
        StartCoroutine(EmpezarCuentaAtras(GameController.TiempoJuego = 200));
       
    }

    private static void EstablecerVidaJugador()
    {
        GameController.Vida = Vida;
    }

    private static void EstablecerNombreJugadorPorDefecto()
    {
        if (GameController.NombreJugador == null)
            GameController.NombreJugador = "Player 1";
    }

    private static void EstablecerBalas()
    {
        GameController.BalasCargador = BalasCargador;
        GameController.BalasTotales = BalasTotales;
        GameController.BalasRestantes = BalasRestantes;
    }

    // Update is called once per frame
    void Update()
    {
        _healthUI.text = "+ " + GameController.Vida;
        _bullethUI.text = GameController.BalasCargador + "/" + GameController.BalasRestantes;
        _TimeUI.text = string.Format("{0:D1}:{1:D2}", _timeSpan.Minutes, _timeSpan.Seconds);
    }
    
    public IEnumerator EmpezarCuentaAtras(float tiempoJuego)
    {
        _tiempoJuegoActual = tiempoJuego;
        while (_tiempoJuegoActual > 0)
        {
            Debug.Log("Cuenta atrás: " + _tiempoJuegoActual);
            yield return new WaitForSeconds(1.0f);
            _tiempoJuegoActual--;
            _timeSpan = TimeSpan.FromSeconds(_tiempoJuegoActual);
        }
        
        Debug.Log("FIN!!");
    }
}