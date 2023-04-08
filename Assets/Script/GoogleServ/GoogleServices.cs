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

     // DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
      PlayGamesPlatform.Activate();
      PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
      void ProcessAuthentication(SignInStatus status)
      {
        if (status == SignInStatus.Success)
        {

        }
        else
        {

        }
      }

    }
    public void ShowTableRecord()
    {
      Social.ShowLeaderboardUI();
    }
    public void SaveTableRecord(int record)
    {
      Social.ReportScore(record, InfinityRecord, (bool success) => { });
    }
    public void SignInGoogle()
    {
      PlayGamesPlatform.Activate();
      PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
      void ProcessAuthentication(SignInStatus status)
      {
        if (status == SignInStatus.Success)
        {

        }
        else
        {

        }
      }
    }
    public void SignOutGoogle()
    {

    }
  }
}
