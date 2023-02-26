using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;
    [SerializeField] public GameObject menuGanar;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textMesh.text = puntos.ToString("0");
    }

    public void SumarPuntos(float puntosInicio) {
        puntos += puntosInicio;
        if (puntos == 600)
        {
            Time.timeScale = 0f;
            menuGanar.SetActive(true);
        }
    }
}
