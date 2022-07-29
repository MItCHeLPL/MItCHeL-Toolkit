using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIUtils
{
    private static Dictionary<TextMeshProUGUI, string> savedTextFields = new Dictionary<TextMeshProUGUI, string>();


    public static void ReplaceText(TextMeshProUGUI textField, string from, object to)
    {
        string text;

        if(savedTextFields.ContainsKey(textField))
        {
            text = savedTextFields[textField];
        }
        else
        {
            text = textField.text;
            savedTextFields.Add(textField, text);
        }
        
        text = text.Replace(from, to.ToString());

        textField.text = text;
    }
}
