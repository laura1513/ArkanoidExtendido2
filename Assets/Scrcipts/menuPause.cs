using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPause : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    [SerializeField] private GameObject menuGanar;
    private AdsManager adsManager;
    void Start()
    {
        // Encuentra el objeto AdsManager en la escena
        adsManager = FindObjectOfType<AdsManager>();
    }
    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
        menuGanar.SetActive(false);
        if (adsManager != null)
        {
            adsManager.ShowInterstitialAd();
        }
        else
        {
            Debug.LogError("AdsManager not found");
        }
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        menuGanar.SetActive(false);
    }
    public void RestartN1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("nivel1");
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        menuGanar.SetActive(false);
    }
    public void RestartN2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("nivel2");
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        menuGanar.SetActive(false);
    }
    public void Nivel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("nivel2");
        menuGanar.SetActive(false);
    }
    public void RestartN3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("nivel3");
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        menuGanar.SetActive(false);
    }
    public void Nivel3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("nivel3");
        menuGanar.SetActive(false);
    }
    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("inicio");
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        menuGanar.SetActive(false);
    }
}
