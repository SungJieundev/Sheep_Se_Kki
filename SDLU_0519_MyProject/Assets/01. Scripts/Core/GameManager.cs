using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Transform sheepPooler;
    public Transform bulletPooler;
    public Transform maxPos;
    public Transform minPos;

    public Queue<GameObject> sheepPooling = new Queue<GameObject>();
    public Queue<GameObject> bulletPooling = new Queue<GameObject>();

    public float currentTime = 0;
    public int tamedCount = 0;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        Debug.Log(sheepPooling.Count);
    }

    public void DeSpawn(Transform pooler, Queue<GameObject> pooling, GameObject obj)
    {
        obj.SetActive(false);
        pooling.Enqueue(obj);
        obj.transform.SetParent(pooler);
    }

   
    
}
