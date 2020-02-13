using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SalirJuego : MonoBehaviour
{
    private bool _ocultar;
    private Canvas _canvasMenu;
    private TextMeshProUGUI _healthUI;

    // Use this for initialization
    void Start()
    {
        _canvasMenu = GameObject.Find("CanvasMenu").gameObject.GetComponent<Canvas>();
        _healthUI = GameObject.Find("Health").GetComponent<TextMeshProUGUI>();
        _ocultar = false;
        SetCanvasVisible(false);
        InicializarComponentesCanvasMenu();
        
    }

    private void InicializarComponentesCanvasMenu()
    {
        _canvasMenu.GetComponentInChildren<TextMeshProUGUI>().text = GameController.NombreJugador;
    }
    private void InicializarComponentesCanvasUI()
    {
        _healthUI.text = "+ " + GameController.Vida;
        Debug.Log(GameController.Vida);
    }

    private void SetCanvasVisible(bool estado)
    {
        _canvasMenu.gameObject.SetActive(estado);
    }

    // Update is called once per frame
    void Update()
    {
        InicializarComponentesCanvasUI();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SalirJuegoMenu();
        }
    }

    private void SalirJuegoMenu()
    {
        if (_ocultar)
        {
            SetCanvasVisible(true);
            _ocultar = !_ocultar;
            Time.timeScale = 0;
            GameController.TiempoPausado = true;
        }
        else
        {
            SetCanvasVisible(false);
            _ocultar = !_ocultar;
            Time.timeScale = 1;
            GameController.TiempoPausado = false;
            
        }
    }
}