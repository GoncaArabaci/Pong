using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public Rigidbody2D ball;
    
    public float AISpeed ;

    
    private void Update()
    {
        if (ball.position.x >=0)
        {

            if (this.ball.position.y > this.transform.position.y)
            {
                transform.Translate(Vector2.up * Time.deltaTime * AISpeed);
            }
            else if(this.ball.position.y < this.transform.position.y)
            {
                transform.Translate(Vector2.down * Time.deltaTime * AISpeed);
            }
            else
            {   
                if (this.transform.position.y > 0)
                {
                    transform.Translate(Vector2.down * Time.deltaTime * AISpeed);
                }
                else if (this.transform.position.y < 0)
                {
                    transform.Translate(Vector2.up * Time.deltaTime * AISpeed);
                }
            }
        }
    }
}
