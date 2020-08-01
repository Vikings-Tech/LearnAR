using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorModeScript : MonoBehaviour
{
    public event Action colorChange;
    public ColorSettings settings;
    public static Color bgColor;
    public static Sprite logo;
    public static Color textField;
    public static Color textColor;
    public static bool isDark = true;
    
    private void Start()
    {
        if (isDark)
        {
            textColor = settings.textColor[0];
            bgColor = settings.modeColor[0];
            logo = settings.Logo[0];
            textField = settings.textBoxColor[0];
        }
        else
        {
            textColor = settings.textColor[1];
            bgColor = settings.modeColor[1];
            logo = settings.Logo[1];
            textField = settings.textBoxColor[1];
        }
    }

    
    public void ModeChange()
    {
        isDark = !isDark;
        if (isDark)
        {
            bgColor = settings.modeColor[0];
            logo = settings.Logo[0];
            textField = settings.textBoxColor[0];
        }
        else
        {
            bgColor = settings.modeColor[1];
            logo = settings.Logo[1];
            textField = settings.textBoxColor[1];
        }

        colorChange?.Invoke();
    }

    
}
