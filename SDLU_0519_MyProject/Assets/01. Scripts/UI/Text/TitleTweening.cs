using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TitleTweening : MonoBehaviour
{
    [SerializeField] Text titleTxt;

    private void Start()
    {
        StartCoroutine(TweenTitle());
    }

    private IEnumerator TweenTitle()
    {
        Sequence seq = DOTween.Sequence();

        while(true)
        {
            seq.Append(titleTxt.rectTransform.DOScale(new Vector3(0.95f, 0.95f), 3f));
            yield return new WaitForSeconds(3f);
            seq.Append(titleTxt.rectTransform.DOScale(new Vector3(1.05f, 1.05f), 3f));
            yield return new WaitForSeconds(3f);
        }
    }
}
