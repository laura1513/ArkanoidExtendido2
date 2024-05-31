using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    private string gameId = "e03e690a-545f-49ab-8b89-97b036d19a7e"; // Obtén esto de tu panel de Unity Ads
    private string interstitialPlacementId = "video"; // El Placement ID para anuncios intersticiales
    private string bannerPlacementId = "banner"; // El Placement ID para banners
    private bool testMode = true;

    void Start()
    {
        // Inicializar Unity Ads
        Advertisement.Initialize(gameId, testMode);
        StartCoroutine(ShowBannerWhenReady());
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(bannerPlacementId))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(bannerPlacementId);
    }

    public void ShowInterstitialAd()
    {
        if (Advertisement.IsReady(interstitialPlacementId))
        {
            Advertisement.Show(interstitialPlacementId);
        }
        else
        {
            Debug.Log("Interstitial ad not ready");
        }
    }
}