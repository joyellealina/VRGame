using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivateAcidRain : MonoBehaviour
{
	public GameObject RainPrefab;
	public Button rain;
	public static bool acidRain = false;

	public void ToggleRain()
	{
		acidRain = true;
		RainPrefab.SetActive(true);
		Debug.Log("Acid Rain is now on");
	}
}