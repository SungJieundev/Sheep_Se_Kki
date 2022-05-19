using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject fadeCanvas;
    [SerializeField] Image fadeIamge;

    public void GameStart()
    {
        fadeCanvas.SetActive(true);
        fadeIamge.DOFade(1f, 1.5f).OnComplete(() =>
        {
            SceneManager.LoadScene("Play");
        });
    }
}
