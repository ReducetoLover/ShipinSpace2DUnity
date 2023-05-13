using UnityEngine;
using UnityEngine.Advertisements;

namespace Reducer
{
  public class Interstitial : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
  {
    [SerializeField] private string androidAdUnitId = "Interstitial_Android";
    [SerializeField] private string iOSAdUnitId = "Interstitial_iOS";
    private string adUnitId;
    private void Awake()
    {
      adUnitId = (Application.platform == RuntimePlatform.IPhonePlayer)
       ? iOSAdUnitId
       : androidAdUnitId;
    }
    public void LoadAd()
    {
      print($"Loading Ad: {adUnitId}");
      Advertisement.Load(adUnitId,this);
    }
    public void ShowAd()
    {
      print($"Showing Ad: {adUnitId}");
      Advertisement.Show(adUnitId, this);
    }
    public void OnUnityAdsAdLoaded(string placementId)
    {
      
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
      print($"Error loading Ad Unit: {adUnitId} - {error.ToString()} - {message}");
    }
    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
      print($"Error showing Ad Unit: {adUnitId}: - {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowClick(string placementId)
    {
      throw new System.NotImplementedException();
    }
    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
      LoadAd();
    }
    public void OnUnityAdsShowStart(string placementId)
    {
      
    }
  }
}
