using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTamedCount : MonoBehaviour
{
    [SerializeField] Text countText;

    private void Start()
    {
        TextCount(); 
    }

    private void TextCount()
    {
        countText.text = $"X {PlayerPrefs.GetInt("TamedCount"),0}";
    }

    
}
