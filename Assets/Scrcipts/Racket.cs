using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public Movimiento movimiento;
    void Update()
    {
        // Get Horizontal Input
        //float h = Input.GetAxisRaw("Horizontal");
        
        // Set Velocity (movement direction * speed)
        //GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movimiento.SetDirection(Vector2.left);
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movimiento.SetDirection(Vector2.right);
        }
    }

    private void Awake()
    {
        movimiento = GetComponent<Movimiento>();
    }
    public void mueveteIzquierda()
    {
        movimiento.SetDirection(Vector2.left);
    }

    public void mueveteDerecha()
    {
        movimiento.SetDirection(Vector2.right);
    }
}
