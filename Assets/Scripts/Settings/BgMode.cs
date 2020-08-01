using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BgMode : MonoBehaviour
{
    private ColorModeScript _colorModeScript;

    private void Start()
    {
        _colorModeScript = FindObjectOfType<ColorModeScript>();
        _colorModeScript.colorChange += Change;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void Change()
    {
        GetComponent<Image>().color = ColorModeScript.bgColor;
        Debug.Log("Apply");
    }
}
