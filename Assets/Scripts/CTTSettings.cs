using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTTSettings
{
    public static float volume;

    public static void SavePrefs()
    {
        Debug.Log("Saving settings");
        PlayerPrefs.SetFloat("Volume", volume);
        PlayerPrefs.Save();
    }

    public static void LoadPrefs()
    {
        Debug.Log("Loading settings");
        volume = PlayerPrefs.GetFloat("Volume", 0.5f);
    }
}
