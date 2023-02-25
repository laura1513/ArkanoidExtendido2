using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private float cantidad;
    [SerializeField] private Puntos puntos;
    void OnCollisionEnter2D(Collision2D collisionInfo) {
        puntos.SumarPuntos(cantidad);
        Destroy(gameObject);
    }
}
