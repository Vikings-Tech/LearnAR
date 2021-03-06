﻿
using UnityEngine;
using UnityEngine.UI;
public class LogoMode : MonoBehaviour
{
    private ColorModeScript _colorModeScript;

    private void Start()
    {
        _colorModeScript = FindObjectOfType<ColorModeScript>();
        _colorModeScript.colorChange += Change;
    }

    
    void Change()
    {
        GetComponent<Image>().sprite = ColorModeScript.logo;
        Debug.Log("Apply");
    }
}
