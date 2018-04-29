using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void FloodGame (){
		SceneManager.LoadScene (1);
	}

	public void AcidGame (){
		SceneManager.LoadScene (2);
	}

	public void TornadoGame (){
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
