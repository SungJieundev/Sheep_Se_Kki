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
        mask.localScale = startScale; //����ũ ũ�� �ʱ�ȭ
        mask.localPosition = startPos; //����ũ ��ġ �ʱ�ȭ
        maskScale = mask.localScale; //����ũ������ ����
        fillAmount = maskScale.y / 3f; //���� ��ġ ����
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
