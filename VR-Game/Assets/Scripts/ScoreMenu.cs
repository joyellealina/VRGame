using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class ScoreMenu : MonoBehaviour {

	public TextMeshProUGUI times;
	public TextMeshProUGUI dates;

	void Start () {
		StreamReader reader = new StreamReader("Assets/Scores.txt");
		times.text = reader.ReadToEnd ();
		reader.Close ();
		reader = new StreamReader("Assets/Dates.txt");
		dates.text = reader.ReadToEnd ();
		reader.Close ();
	}
}
