using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
#if UNITY_ANDROID
    string gameId = "5350579";
    string myPlacementId = "Rewarded_Android";
#else
    string gameId = "5350578";
    string myPlacementId = "Rewarded_iOS";
#endif

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameId, true, this);
    }

    public void PlayRewardedAd()
    {
        Advertisement.Load(myPlacementId, this);
    }

    // Implement the IUnityAdsInitializationListener interface methods:
    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialized.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log("Unity Ads initialization failed: " + message);
    }

    // Implement the IUnityAdsLoadListener interface methods:
    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("Ads are ready");
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId)
        {
            Advertisement.Show(myPlacementId, this);
        }
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log("Error: " + message);
    }

    // Implement the IUnityAdsShowListener interface methods:
    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log("Show failure: " + message);
    }

    public void OnUnityAdsShowStart(string placementId) { }
    public void OnUnityAdsShowClick(string placementId) { }
    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        if (placementId == myPlacementId && showCompletionState == UnityAdsShowCompletionState.COMPLETED)
        {
            Debug.Log("Player should receive reward");
        }
    }
}