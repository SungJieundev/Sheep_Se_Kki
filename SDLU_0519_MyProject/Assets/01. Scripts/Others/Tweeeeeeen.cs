using DG.Tweening;
using System.Collections;
using UnityEngine;

public class Tweeeeeeen : MonoBehaviour
{
    [SerializeField] float duration = 5f;

    private void Start()
    {
        StartCoroutine(Tweeeeeeeeeeen());
    }

    private IEnumerator Tweeeeeeeeeeen()
    {
        while(true)
        {
            Quaternion rotate = transform.rotation;
            transform.DORotate(new Vector3(0, 0, rotate.z - 360), duration, RotateMode.FastBeyond360);
            yield return new WaitForSeconds(duration);
        }
    }
}
