using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    private Material bg = null;
    [SerializeField] Vector2 scrollDir = Vector2.zero;

    private void Start()
    {
        bg = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        BackgroundScroll();
    }

    private void BackgroundScroll()
    {
       bg.mainTextureOffset += scrollDir * Time.deltaTime;
    }
}
