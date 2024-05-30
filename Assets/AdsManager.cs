using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    private string gameId = "e03e690a-545f-49ab-8b89-97b036d19a7e"; // Obtén esto de tu panel de Unity Ads
    private bool testMode = true;

    void Start()
    {
        // Inicializar Unity Ads
        Advertisement.Initialize(gameId, testMode);
    }

    public void ShowInterstitialAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("Banner");
        }
        else
        {
            Debug.Log("Ad not ready");
        }
    }
}
