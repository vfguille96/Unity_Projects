using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class CalculateScore : MonoBehaviour {

	// Use this for initialization
	private string path = @"score.txt";
	private TextMeshProUGUI _tmScore;
	void Start ()
	{
		_tmScore = gameObject.GetComponent<TextMeshProUGUI>();
		GenerateAndSetScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void GenerateAndSetScore()
	{
		float score = Random.Range(100, 99999);
		_tmScore.text = score.ToString();
		
			string scoreToWrite = score + ";";
			if (!File.Exists(path))
				File.WriteAllText(path, scoreToWrite);
			else
				File.AppendAllText(path, scoreToWrite);
	}
}