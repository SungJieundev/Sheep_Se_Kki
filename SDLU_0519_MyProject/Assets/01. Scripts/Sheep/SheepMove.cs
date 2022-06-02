using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMove : MonoBehaviour
{
    [SerializeField] float minJumpPower;
    [SerializeField] float maxJumpPower;
    [SerializeField] float speed = 5f;
    [SerializeField] LayerMask groundLayer;
    private float jumpPower;
    private Rigidbody2D rb2d = null;
    private Collider2D col2d = null;

    private void OnEnable() //활성화 될 때마다 호출 
    {
        jumpPower = Random.Range(minJumpPower, maxJumpPower);//minJumpPower, maxJumpPower 사이의 랜덤한 값을 jumpPower로 정의
    }

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        col2d = GetComponent<Collider2D>();
    }

    private void Update()
    {
        Movement();
        Bounce();
    }

    private void Movement()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if(gameObject.transform.position.x < GameManager.Instance.minPos.position.x)
            GameManager.Instance.DeSpawn(GameManager.Instance.sheepPooler, GameManager.Instance.sheepPooling, gameObject);
    }

    private void Bounce()
    {
        if (IsGround())
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }

    private bool IsGround()
    {
        return Physics2D.OverlapBox(col2d.bounds.center, col2d.bounds.size, 0, groundLayer);
    }
}
