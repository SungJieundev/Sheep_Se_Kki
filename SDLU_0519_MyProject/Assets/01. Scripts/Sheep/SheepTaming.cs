using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepTaming : MonoBehaviour
{
    [SerializeField] int maxhp = 3;
    private int currenthp;

    private void OnEnable()
    {
        currenthp = maxhp;
    }

    private void Update()
    {
        IsTamed();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            currenthp--;
            transform.GetChild(0).GetComponent<SheepHeart>().FillHeart();
            GameManager.Instance.DeSpawn(GameManager.Instance.bulletPooler, GameManager.Instance.bulletPooling, other.gameObject);
        }
    }

    private void IsTamed()
    {
        if(currenthp <= 0)
        {
            GameManager.Instance.DeSpawn(GameManager.Instance.sheepPooler, GameManager.Instance.sheepPooling, gameObject);
            GameManager.Instance.tamedCount++;
        }
    }
}
