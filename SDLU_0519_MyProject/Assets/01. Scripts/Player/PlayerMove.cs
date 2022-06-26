using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] Transform playerMax;
    [SerializeField] Transform playerMin;

    private Vector2 MaxPos => playerMax.position;
    private Vector2 MinPos => playerMin.position;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector2(hori, verti).normalized * speed * Time.deltaTime);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, MinPos.x, MaxPos.x),
            Mathf.Clamp(transform.position.y, MinPos.y, MaxPos.y));
    }
}
