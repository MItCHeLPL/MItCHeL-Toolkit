using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Slider))]
public class SliderValue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private Slider slider;
    

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        slider.onValueChanged.AddListener(UpdateSliderValue);
    }

    private void OnDisable()
    {
        slider.onValueChanged.RemoveListener(UpdateSliderValue);
    }


    private void UpdateSliderValue(float value)
	{
		text.SetText(value.ToString("F2"));
	}
}
