using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivateAcidRain : MonoBehaviour
{
	public GameObject RainPrefab;
	public Button rain;

	public void ToggleRain()
	{
		RainPrefab.SetActive(true);
		Debug.Log("Acid Rain is now on");
	}
}