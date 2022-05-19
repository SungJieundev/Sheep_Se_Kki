using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public static PlayerFire Instance;

    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPooler;
    [SerializeField] float delay = 0.5f;
    public Vector3 MousePos { get; set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        StartCoroutine(FIreBullet());
    }

    private IEnumerator FIreBullet()
    {
        while(true)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if(bulletPooler.childCount > 0)
                {
                    GameObject temp = GameManager.Instance.bulletPooling.Dequeue();
                    temp.transform.SetParent(null);
                    temp.transform.rotation = Quaternion.identity;
                    temp.transform.position = transform.position;
                    temp.SetActive(true);
                }
                else
                    Instantiate(bullet, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(delay);
            }
            yield return null;
        }
    }
}
