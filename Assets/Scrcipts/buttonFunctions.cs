using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFunctions : MonoBehaviour
{
    public void Nivel1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("nivel1");
    }

    public void Nivel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("nivel2");
    }

    public void Nivel3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("nivel3");
    }

    public void SelectLevels()
    {
        SceneManager.LoadScene("seleccionNiveles");
    }
    public void Inicio()
    {
        SceneManager.LoadScene("inicio");
    }
    public void Info()
    {
        SceneManager.LoadScene("info");
    }
}
