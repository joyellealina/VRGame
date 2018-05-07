using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class WinMenu : MonoBehaviour {

	public GameObject main;
	public GameObject win;
	public float gameTimer;
	public TextMeshProUGUI winTime;

	void Update () {
		gameTimer += Time.deltaTime;	// Keeps track of time taken to win

		if (BoatMovement.win == true) {
			winTime.text = (gameTimer).ToString ("0.0"); // Display time
			StreamWriter writer = new StreamWriter("Assets/Scores.txt");
			writer.WriteLine (winTime.text);
			writer.Close ();
			win.SetActive (true);
			main.SetActive (false);
		}
	}
}
