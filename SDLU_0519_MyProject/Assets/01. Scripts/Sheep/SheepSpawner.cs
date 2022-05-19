using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpawner : MonoBehaviour
{
    public static SheepSpawner Instance;

    [SerializeField] GameObject sheep;
    [SerializeField] float startDelay = 10f;
    [SerializeField] float currentDelay = 10f;



    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }

    private void Start()
    {
        StartCoroutine(InstantiateOrPool());
    }

    private void Update()
    {
        currentDelay = startDelay - (GameManager.Instance.currentTime / 36);
    }

    private IEnumerator InstantiateOrPool()
    {
        while(true)
        {
            float posY = Random.Range(GameManager.Instance.minPos.position.y, GameManager.Instance.maxPos.position.y);
            if (gameObject.transform.childCount > 0)
            {
                GameObject sheep = GameManager.Instance.sheepPooling.Dequeue();
                sheep.transform.SetParent(null);
                sheep.transform.position = new Vector2(GameManager.Instance.maxPos.position.x, posY);
                sheep.SetActive(true);
            }
            else
                Instantiate(sheep, new Vector2(GameManager.Instance.maxPos.position.x, posY), Quaternion.identity);
            yield return new WaitForSeconds(currentDelay);
        }
    }
}
