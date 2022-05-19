using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;


public class TimeOver : MonoBehaviour
{
    [SerializeField] GameObject fadeCanvas;
    [SerializeField] Image fadeIamge;


    private void Start()
    {
        StartCoroutine(GameOver());
    }

    public IEnumerator GameOver()
    {
        while (true)
        {
            if(GameManager.Instance.currentTime >= 180)
            {
                fadeCanvas.SetActive(true);
                fadeIamge.DOFade(1f, 1.5f).OnComplete(() =>
                {
                    PlayerPrefs.SetInt("TamedCount" , GameManager.Instance.tamedCount);
                    SceneManager.LoadScene("GameOver");
                });
                break;
            }

            yield return null;
        }
    }
}
