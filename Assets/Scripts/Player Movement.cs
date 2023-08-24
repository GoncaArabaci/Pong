using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float PlayerSpeed = 5f;
    //Camera cam;
    //float width;

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W) )//&& transform.position.x > -width)
        {
            transform.Translate(Vector2.up * Time.deltaTime * PlayerSpeed);
        }
        if (Input.GetKey(KeyCode.S) )//&& transform.position.x < width)
        {
            transform.Translate(Vector2.down * Time.deltaTime * PlayerSpeed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            collision.gameObject.SetActive(true);
        }
    }

    /*private void Awake()
    {
        cam = Camera.main;
        width = ((1 / (cam.WorldToViewportPoint(new Vector3(1, 1 , 0)).x - .5f) / 2) - 0.5f);
    }*/
}
