using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public Corner pos;

    public float speed = 100;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //pos = canvas.GetComponent<Corner>();
        moveLeft = false;
        moveRight = false;
    }

    public void DownLeft()
    {
        moveLeft = true;
    }

    public void UpLeft()
    {
        moveLeft = false;
    }

    public void DownRight()
    {
        moveRight = true;   
    }

    public void UpRight()
    {
        moveRight = false;
    }

    public void TopLeft()
    {
        transform.position = new Vector2(0.0f, Screen.height);
    }

    private void MovementPlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed * Time.deltaTime;
        }
        else if (moveRight)
        {
            horizontalMove = speed * Time.deltaTime;
        }
        else
        {
            horizontalMove = 0; 
        }
    }
    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, 0.0f);
    }
}
