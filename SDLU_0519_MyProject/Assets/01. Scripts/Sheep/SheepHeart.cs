using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheepHeart : MonoBehaviour
{
    

    [SerializeField] float fillAmount = 0;

    private Vector3 startScale;
    private Vector3 startPos;
    private Vector3 maskScale;
    private Transform mask = null;

    private void Awake()
    {
        mask = transform.GetChild(0);
        startScale = mask.localScale;
        startPos = mask.localPosition;
    }

    private void OnEnable()
    {
        mask.localScale = startScale; //마스크 크기 초기화
        mask.localPosition = startPos; //마스크 위치 초기화
        maskScale = mask.localScale; //마스크스케일 정의
        fillAmount = maskScale.y / 3f; //감소 수치 정의
    }

    public void FillHeart()
    {
        maskScale.y -= fillAmount;

        Vector3 maskPos = mask.localPosition;
        maskPos.y += fillAmount * 0.5f;

        mask.localPosition = maskPos;
        mask.localScale = maskScale;
    }
}
