using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

	public Image progress;

	void Update () {
		progress.fillAmount = 0.1F * BoatMovement.score;
	}
}
