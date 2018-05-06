using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour {

	public TextMeshProUGUI sliderValue1;
	public TextMeshProUGUI inverseSliderValue1;
	public TextMeshProUGUI sliderValue2;
	public TextMeshProUGUI inverseSliderValue2;
	public Slider slider1;
	public Slider slider2;

	void Update () {
		sliderValue1.text = (slider1.value * 100).ToString ("0");
		inverseSliderValue1.text = (100 - slider1.value * 100).ToString ("0");
		sliderValue2.text = (slider2.value * 100).ToString ("0");
		inverseSliderValue2.text = (100 - slider2.value * 100).ToString ("0");
	}
}
