using UnityEngine;
using UnityEngine.Advertisements;

namespace Reducer
{
  public class AdsCore : MonoBehaviour, IUnityAdsInitializationListener
  {
    [SerializeField] private bool testMode = true;
    [SerializeField] private string _adnroidGameId;
    [SerializeField] private string _iOSGameId;
    private string _gameId;
    
    private void Awake()
    {
      InitializeAds();
    }
    private void InitializeAds()
    {
      _gameId = _adnroidGameId;
       
      Advertisement.Initialize(_gameId, testMode, this);
    }

    public void OnInitializationComplete()
    {
      print("Ads complete");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
      print($"Ads not complete {error.ToString()} - {message}");
    }
  }
}

