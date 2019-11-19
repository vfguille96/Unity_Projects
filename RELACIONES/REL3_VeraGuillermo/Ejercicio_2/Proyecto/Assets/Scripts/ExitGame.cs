using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    private Canvas canvas;
    public Button button;

    // Use this for initialization
    void Start()
    {
        button.onClick.AddListener(MenuExit);
        canvas = GameObject.Find("CanvasExit").GetComponent<Canvas>();
        SetEnableCanvasExit(false);
    }

    // Update is called once per frame
    void Update()
    {
        QuitGameEsc();
    }

    public void MenuExit()
    {
        switch (button.name)
        {
            case "btSalir":
                QuitGame();
                break;
            case "btVolver":
                SetEnableCanvasExit(false);
                break;
        }
    }

    private void SetEnableCanvasExit(bool enabled)
    {
        canvas.enabled = enabled;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void QuitGameEsc()
    {
        if (Input.GetKey(KeyCode.Escape))
            SetEnableCanvasExit(true);
    }
}