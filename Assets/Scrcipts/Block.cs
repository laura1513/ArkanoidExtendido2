using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private float cantidad;
    [SerializeField] private Puntos puntos;
    [SerializeField] private int intentos;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (gameObject.name == "block_grey")
        {
            if (intentos == 1)
            {
                intentos = intentos - 1;
            } else if (intentos == 0)
            {
                puntos.SumarPuntos(cantidad);
                Destroy(gameObject);
                intentos = 1;
            }
        }
        else
        {
            puntos.SumarPuntos(cantidad);
            Destroy(gameObject);
        }
    }
}
