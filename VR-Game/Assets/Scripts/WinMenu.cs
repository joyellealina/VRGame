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
	public string gameMode;

	void Update () {
		gameTimer += Time.deltaTime;	// Keeps track of time taken to win

		if (BoatMovement.win == true) {
			BoatMovement.win = false;	// Resets win condition
			winTime.text = (gameTimer).ToString ("0.0"); // Display time
			StreamWriter writer = new StreamWriter("Assets/Scores.txt", append: true);
			writer.WriteLine (winTime.text);
			writer.Close ();
			writer = new StreamWriter("Assets/Dates.txt", append: true);
			writer.WriteLine (gameMode);
			writer.Close ();
			win.SetActive (true);
			main.SetActive (false);
		}
	}
}
