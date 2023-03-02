using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Vector2 direccion;
    public float speed = 8;
    void FixedUpdate()
    {
        Vector2 position = GetComponent<Rigidbody2D>().position;
        Vector2 traduccion = direccion * (speed * Time.fixedDeltaTime);
        GetComponent<Rigidbody2D>().MovePosition(position + traduccion);
    }

    public void SetDirection(Vector2 direccion)
    {
        this.direccion = direccion;
    }
}
