using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigid;
    float BallSpeed = 100.0f;
    public GameManager gameManager;

    void Start()
    {
        resetPos();
    }
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void StartMove() 
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f ;
        float y = Random.value < 0.5f ? Random.Range(-0.6f, -0.5f) : Random.Range(0.5f, 0.6f);

        Vector2 directions = new Vector2(x, y);
        rigid.AddForce(directions * BallSpeed);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            collision.gameObject.SetActive(true);
        }
    }
    public void AddForce(Vector2 force)
    {
        rigid.AddForce(force);
    }
    public void resetPos()
    {
        gameObject.transform.position = new Vector2(0 ,0);
        rigid.velocity = new Vector2(0, 0);

        StartMove();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerSide"))
        {
            Debug.Log("Scored");
            gameManager.AIScore();
            
        }
        if (collision.CompareTag("ComputerSide"))
        {
            Debug.Log("Scored");
            gameManager.PlayerScore();
            
        }
        resetPos();
    }
}
