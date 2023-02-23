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
    public void Inicio()
    {
        SceneManager.LoadScene("inicio");
    }
    public void Info()
    {
        SceneManager.LoadScene("info");
    }

    [SerializeField] private GameObject botonPause;
    [SerializeField] private GameObject menuPause;
    
    public void Pause()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("pauseMenu");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("nivel1");
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        
    }
}
