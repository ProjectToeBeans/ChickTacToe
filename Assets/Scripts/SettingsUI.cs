using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class SettingsUI : MonoBehaviour
{
        public Slider volumeSlider;

        public void Start()
        {
            volumeSlider.value = CTTSettings.volume;
            volumeSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
        }

        public void ValueChangeCheck()
        {
            Debug.Log(volumeSlider.value);
            CTTSettings.volume = volumeSlider.value;
            CTTSettings.SavePrefs();
        }
}
