using UnityEngine;
using UnityEngine.UI;
public class InputFieldMode : MonoBehaviour
{
    private ColorModeScript _colorModeScript;

    private void Start()
    {
        _colorModeScript = FindObjectOfType<ColorModeScript>();
        _colorModeScript.colorChange += Change;
    }
    
    void Change()
    {
        GetComponent<Image>().color = ColorModeScript.textField;
        Debug.Log("Apply");
    }
}
