using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFunctions : MonoBehaviour
{
    public void Nivel1()
    {
        SceneManager.LoadScene("nivel1");
    }

    public void SelectLevels()
    {
        SceneManager.LoadScene("seleccionNiveles");
    }
}
