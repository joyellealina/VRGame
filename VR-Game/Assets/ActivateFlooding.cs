using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivateFlooding : MonoBehaviour
{
    public GameObject RainPrefab;
    public GameObject FloodWater;
    public Button rain;

    public void ToggleRain()
    {
        RainPrefab.SetActive(true);
        FloodWater.SetActive(true);
        Debug.Log("Rain is now on");
    }

    private void Update()
    {
        // This will trigger the slow movement of the FloodWater in the scene
    }
}