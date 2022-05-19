using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float duration = 0f;
    private Vector3 dir;

    private void OnEnable()
    {
        dir = PlayerFire.Instance.MousePos - transform.position;
        dir.z = 0;
        transform.DORotate(new Vector3(0f,0f,360f), duration, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
    }


    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        Vector2 pos = transform.position;
        Vector2 minPos = GameManager.Instance.minPos.position;
        Vector2 maxPos = GameManager.Instance.maxPos.position;

        if (pos.x < minPos.x || pos.x > maxPos.x || pos.y < minPos.y || pos.y > maxPos.y)
            GameManager.Instance.DeSpawn(GameManager.Instance.bulletPooler, GameManager.Instance.bulletPooling, gameObject);
    }
}
