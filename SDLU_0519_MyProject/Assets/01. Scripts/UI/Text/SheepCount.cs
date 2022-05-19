 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheepCount : MonoBehaviour
{
    [SerializeField] Text sheepCountText;

    private void Update()
    {
        CountText();
    }

    private void CountText()
    {
        sheepCountText.text = $"X {GameManager.Instance.tamedCount}";
    }
}
