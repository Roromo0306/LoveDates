using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNave : MonoBehaviour
{
    private float velocidad = 5f;

    private Sprite izEs;
    private Sprite derEs;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private Vector2 movimiento;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
       movimiento.x = Input.GetAxis("Horizontal");

        if( movimiento.x < 0)
        {
            sr.sprite = izEs;
        }
        else
        {
            if(movimiento.x > 0)
            {
                sr.sprite= derEs;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento*velocidad*Time.fixedDeltaTime);
    }


}
