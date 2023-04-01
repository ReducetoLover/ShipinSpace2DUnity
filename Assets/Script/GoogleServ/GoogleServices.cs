using GooglePlayGames;
using GooglePlayGames.BasicApi;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Reducer
{
  public class GoogleServices : MonoBehaviour
  {

    private const string InfinityRecord = "CgkIk7_v44UOEAIQAQ";
    private void Awake()
    {
      GameObject objs = GameObject.Find("GPs");

      DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
      PlayGamesPlatform.Activate();
      PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
      //Social.localUser.Authenticate((bool success) => { });
      void ProcessAuthentication(SignInStatus status)
      {
        if (status == SignInStatus.Success)
        {
          // Continue with Play Games Services
        }
        else
        {
          // Disable your integration with Play Games Services or show a login button
          // to ask users to sign-in. Clicking it should call
          // PlayGamesPlatform.Instance.ManuallyAuthenticate(ProcessAuthentication).
        }
      }

    }
    public void ShowTableRecord()
    {
      Social.ShowLeaderboardUI();
    }
  }
}
