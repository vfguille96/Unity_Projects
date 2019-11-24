using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    private Canvas canvas;
    public Button button;
    private bool flag;

    // Use this for initialization
    void Start()
    {
        button.onClick.AddListener(MenuExit);
        canvas = GameObject.Find("CanvasExit").GetComponent<Canvas>();
        SetEnableCanvasExit(false);
        flag = false;
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
            case "btExit":
                QuitGame();
                break;
            case "btBack":
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
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (!flag)
            {
                SetEnableCanvasExit(true);
                flag = true;
            }
            else
            {
                SetEnableCanvasExit(false);
                flag = false;
            }
        }
    }
}