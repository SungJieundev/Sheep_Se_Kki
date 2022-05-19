using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject panel;


    public void MenuButton()
    {
        SceneManager.LoadScene("Start");
    }

    public void StartMenu()
    {
        panel.SetActive(false);
    }
}
