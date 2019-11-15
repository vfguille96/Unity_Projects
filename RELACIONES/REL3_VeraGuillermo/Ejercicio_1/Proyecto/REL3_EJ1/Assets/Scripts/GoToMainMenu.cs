using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToMainMenu : MonoBehaviour {
	public Button button;
	// Use this for initialization
	void Start () {
		button.onClick.AddListener(IrAMenu);
	}
	
	// Update is called once per frame
	void Update ()
	{
		IrAMenuPrincipalEsc();
	}

	private void IrAMenuPrincipalEsc()
	{
		if (Input.GetKey(KeyCode.Escape))
			IrAMenu();
	}

	private static void IrAMenu() { SceneManager.LoadScene("Menu0"); }
}
