using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    public float speedX;
    public float directionX;
    public float directionY;
    private SpriteRenderer spr;

    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        _rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        _rb2D.velocity = new Vector2(speedX * directionX, speedX*directionY);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Pared")
        {
            directionX = directionX * -1;
            if(spr.flipX == true)
            {
                spr.flipX = false;
            }
            else
            {
                spr.flipX = true;
            }
        }
        if (other.gameObject.tag == "Paredy")
        {
            directionY = directionY * -1;
            if (spr.flipY == true)
            {
                spr.flipY = false;
            }
            else
            {
                spr.flipY = true;
            }
        }

    }
}
