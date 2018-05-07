using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class ScoreMenu : MonoBehaviour {

	public TextMeshProUGUI times;
	public TextMeshProUGUI dates;

	void Update () {
		StreamReader reader = new StreamReader("Assets/Scores.txt");
		times.text = reader.ReadToEnd ();
		reader.Close ();
		reader = new StreamReader("Assets/Dates.txt");
		dates.text = reader.ReadToEnd ();
		reader.Close ();
	}

	// Clears record of scores
	public void Clear () {
		StreamWriter writer = new StreamWriter ("Assets/Scores.txt");
		writer.Write (string.Empty);
		writer = new StreamWriter ("Assets/Dates.txt");
		writer.Write (string.Empty);
		writer.Close ();
	}
}
