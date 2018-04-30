using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivateTornado : MonoBehaviour
{
	public GameObject Tornado;
	public Button start;

	public void ToggleTornado()
	{
		Tornado.SetActive(true);
		Debug.Log("Tornado is now on");
	}
}