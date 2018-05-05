using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void FloodGame (){
		BoatMovement.score = 1; // Resets starting resources
		SceneManager.LoadScene (1);
	}

	public void AcidGame (){
		BoatMovement.score = 1; // Resets starting resources
		SceneManager.LoadScene (2);
	}

	public void TornadoGame (){
		BoatMovement.score = 1;	// Resets starting resources
		SceneManager.LoadScene (3);
	}

	public void QuitGame (){
		Debug.Log ("QUIT");
		Application.Quit();
	}

	public void ReturnMenu (){
		SceneManager.LoadScene (0);
	}
}
