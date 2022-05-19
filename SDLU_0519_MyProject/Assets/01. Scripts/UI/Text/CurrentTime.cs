using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    [SerializeField] Text currentTime;

    private void Update()
    {
        TimeText();    
    }

    private void TimeText()
    {
        currentTime.text = $"{Mathf.Floor(180 - GameManager.Instance.currentTime)}";
    }
}
