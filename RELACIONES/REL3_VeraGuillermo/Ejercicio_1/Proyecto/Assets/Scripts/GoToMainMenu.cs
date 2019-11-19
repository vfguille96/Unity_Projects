using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToMainMenu : MonoBehaviour
{
    public Button button;

    // Use this for initialization
    void Start()
    {
        button.onClick.AddListener(IrAMenu);
    }

    // Update is called once per frame
    void Update()
    {
        IrAMenuPrincipalEsc();
    }

    private void IrAMenuPrincipalEsc()
    {
        if (Input.GetKey(KeyCode.Escape))
            IrAMenu();
    }

    public void IrAMenu()
    {
        switch (button.name)
        {
            case "btMenu":
            case "btMenu2":
            case "btMenu3":
            case "btMenu4":
                SceneManager.LoadScene("Menu0");
                break;
        }
    }
}