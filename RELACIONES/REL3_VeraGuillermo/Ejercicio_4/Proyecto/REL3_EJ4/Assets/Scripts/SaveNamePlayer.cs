using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SaveNamePlayer : MonoBehaviour {

	// Use this for initialization
	private GameObject _button;
	private Button _buttonSave;
	public InputField _inputF;
	public Canvas _canvasName;
	public Canvas _canvasScore;
	private GameObject _canvasso;
	private string path = @"score.txt";
	void Start ()
	{
		_canvasScore.enabled = false;
		_canvasso = GameObject.Find("ImageScore");
		_canvasso.SetActive(false);
		_button = GameObject.Find("BtSaveNamePlayer");
		_button.GetComponent<Button>().onClick.AddListener(SaveNamePlayerFile);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void HideCanvasName()
	{
		_canvasName.enabled = false;
		_canvasScore.enabled = true;
		_canvasso.SetActive(true);
	}

	void SaveNamePlayerFile()
	{
		string namePlayer = _inputF.text + ";";
		if (!File.Exists(path))
			File.WriteAllText(path, namePlayer);
		else
			File.AppendAllText(path, namePlayer);
		
		HideCanvasName();
	}
}
