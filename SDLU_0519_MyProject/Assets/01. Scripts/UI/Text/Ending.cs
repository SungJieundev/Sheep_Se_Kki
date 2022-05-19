using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    [SerializeField] GameObject bad;
    [SerializeField] GameObject soso;
    [SerializeField] GameObject good;

    private void Start()
    {
        switch(PlayerPrefs.GetInt("TamedCount", 0) / 10)
        {
            case 0:
                bad.SetActive(true);
                break;
            case 1:
            case 2:
            case 3:
                soso.SetActive(true);
                break;
            case 4:
            case 5:
                good.SetActive(true);
                break;
        }
    }
}
