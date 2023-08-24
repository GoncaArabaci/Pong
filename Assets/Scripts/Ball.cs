using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigid;
    float BallSpeed = 150.0f;

    void Start()
    {
        StartMove();
    }
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void StartMove() 
    {
        float y = Random.value < 0.5f ? -0.1f : 1.0f ;
        float x = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

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
}
