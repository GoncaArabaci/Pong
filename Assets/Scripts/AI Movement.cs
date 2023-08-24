using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public Rigidbody2D ball;
    Rigidbody2D rigid;
    public float AISpeed ;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (ball.position.x >=0)
        {

        
        if (this.ball.position.y > this.transform.position.y)
        {
            rigid.AddForce(Vector2.up * AISpeed);
        }
        else if(this.ball.position.y< this.transform.position.y)
        {
            rigid.AddForce(Vector2.down * AISpeed);
        }
        else
        {
            if (this.transform.position.y > 0)
            {
                rigid.AddForce(Vector2.down * AISpeed);
            }
            else if (this.transform.position.y < 0)
            {
                rigid.AddForce(Vector2.up * AISpeed);
            }
        }
        }
    }
}
