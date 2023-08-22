using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigid;
    float BallSpeed = 50f;
    

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
        float y ;
        float x = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

        if (Random.value < 0.5f)
        {
            y = 1f;
        }
        else
        {
            y = -1f;
        }
        
        Vector2 directions = new Vector2(x, y);
        rigid.AddForce(directions * this.BallSpeed);

    }

}
